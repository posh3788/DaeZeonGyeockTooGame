#include "EventProcessor.h"
#include <iostream>
#include "PacketBuilder.h"
#include "PacketReader.h"

using namespace std;

EventProcessor::EventProcessor()
{
}

EventProcessor::~EventProcessor()
{
  eventBuffer.reserve(20);
  WaitForStop();
}

void EventProcessor::PushEvent(int64_t networkId, const void* src, size_t size)
{
  std::vector<char> buffer;
  buffer.resize(size);
  memcpy(buffer.data(), src, size);

  LockGuard guard(queueMutex);
  eventQueue.emplace(networkId, std::move(buffer));
}

void EventProcessor::Start()
{
}

void EventProcessor::Update()
{
  eventBuffer.clear();
  {
    LockGuard guard(queueMutex);
    while (!eventQueue.empty())
    {
      eventBuffer.push_back(std::move(eventQueue.front()));
      eventQueue.pop();
    }
  }

  for (auto&& [networkId, packet] : eventBuffer)
  {
    DispatchEvent(networkId, packet.data(), packet.size());
  }
}

void EventProcessor::Run()
{
  this->thread = std::thread([this]() {
    Start();
    while (!shouldStop)
    {
      Update();
    }
  });
}

void EventProcessor::Stop()
{
  shouldStop = true;
}

void EventProcessor::WaitForStop()
{
  if (this->thread.joinable())
  {
    thread.join();
  }
}

void EventProcessor::DispatchEvent(int64_t networkId, const void* src, int size)
{
  packet::PacketReader reader(src, size);
  const packet::PacketHeader& header = *reader.GetPacketHeader();
  
  auto it = handlers.find(static_cast<packet::Type>(header.messageType));
  if (it != handlers.end())
  {
    it->second(networkId, reader.GetSerializedMessagePtr(), header.messageSize);
  }
  else
  {
    HandleDefaultEvent(networkId, src, size);
  }
}
