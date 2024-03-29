// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: packet_type.proto

#ifndef PROTOBUF_INCLUDED_packet_5ftype_2eproto
#define PROTOBUF_INCLUDED_packet_5ftype_2eproto

#include <string>

#include <google/protobuf/stubs/common.h>

#if GOOGLE_PROTOBUF_VERSION < 3006001
#error This file was generated by a newer version of protoc which is
#error incompatible with your Protocol Buffer headers.  Please update
#error your headers.
#endif
#if 3006001 < GOOGLE_PROTOBUF_MIN_PROTOC_VERSION
#error This file was generated by an older version of protoc which is
#error incompatible with your Protocol Buffer headers.  Please
#error regenerate this file with a newer version of protoc.
#endif

#include <google/protobuf/io/coded_stream.h>
#include <google/protobuf/arena.h>
#include <google/protobuf/arenastring.h>
#include <google/protobuf/generated_message_table_driven.h>
#include <google/protobuf/generated_message_util.h>
#include <google/protobuf/inlined_string_field.h>
#include <google/protobuf/metadata.h>
#include <google/protobuf/repeated_field.h>  // IWYU pragma: export
#include <google/protobuf/extension_set.h>  // IWYU pragma: export
#include <google/protobuf/generated_enum_reflection.h>
// @@protoc_insertion_point(includes)
#define PROTOBUF_INTERNAL_EXPORT_protobuf_packet_5ftype_2eproto 

namespace protobuf_packet_5ftype_2eproto {
// Internal implementation detail -- do not use these members.
struct TableStruct {
  static const ::google::protobuf::internal::ParseTableField entries[];
  static const ::google::protobuf::internal::AuxillaryParseTableField aux[];
  static const ::google::protobuf::internal::ParseTable schema[1];
  static const ::google::protobuf::internal::FieldMetadata field_metadata[];
  static const ::google::protobuf::internal::SerializationTable serialization_table[];
  static const ::google::protobuf::uint32 offsets[];
};
void AddDescriptors();
}  // namespace protobuf_packet_5ftype_2eproto
namespace packet {
}  // namespace packet
namespace packet {

enum Type {
  NONE = 0,
  CONNECT = 2,
  DISCONNECT = 3,
  ERROR_ACK = 4,
  LOGIN_REQ = 100,
  LOGIN_ACK = 101,
  ENTER_NEW_USER_REQ = 102,
  ENTER_NEW_USER_ACK = 103,
  MOVE_REQ = 105,
  MOVE_ACK = 106,
  ENTER_ROOM_REQ = 107,
  ENTER_ROOM_ACK = 108,
  GET_ROOM_LIST_REQ = 109,
  GET_ROOM_LIST_ACK = 110,
  MAKE_ROOM_REQ = 111,
  MAKE_ROOM_ACK = 112,
  MOVE_ROOM_USER_REQ = 113,
  MOVE_ROOM_USER_ACK = 114,
  EXIT_ROOM_USER_REQ = 115,
  EXIT_ROOM_USER_ACK = 116,
  ENTER_NEW_ROOM_USER_REQ = 117,
  ENTER_NEW_ROOM_USER_ACK = 118,
  LOGOUT_REQ = 119,
  LOGOUT_ACK = 120,
  CAST_SKILL_REQ = 121,
  CAST_SKILL_ACK = 122,
  CAST_SKILL_HIT_REQ = 123,
  CAST_SKILL_HIT_ACK = 124,
  Type_INT_MIN_SENTINEL_DO_NOT_USE_ = ::google::protobuf::kint32min,
  Type_INT_MAX_SENTINEL_DO_NOT_USE_ = ::google::protobuf::kint32max
};
bool Type_IsValid(int value);
const Type Type_MIN = NONE;
const Type Type_MAX = CAST_SKILL_HIT_ACK;
const int Type_ARRAYSIZE = Type_MAX + 1;

const ::google::protobuf::EnumDescriptor* Type_descriptor();
inline const ::std::string& Type_Name(Type value) {
  return ::google::protobuf::internal::NameOfEnum(
    Type_descriptor(), value);
}
inline bool Type_Parse(
    const ::std::string& name, Type* value) {
  return ::google::protobuf::internal::ParseNamedEnum<Type>(
    Type_descriptor(), name, value);
}
// ===================================================================


// ===================================================================


// ===================================================================

#ifdef __GNUC__
  #pragma GCC diagnostic push
  #pragma GCC diagnostic ignored "-Wstrict-aliasing"
#endif  // __GNUC__
#ifdef __GNUC__
  #pragma GCC diagnostic pop
#endif  // __GNUC__

// @@protoc_insertion_point(namespace_scope)

}  // namespace packet

namespace google {
namespace protobuf {

template <> struct is_proto_enum< ::packet::Type> : ::std::true_type {};
template <>
inline const EnumDescriptor* GetEnumDescriptor< ::packet::Type>() {
  return ::packet::Type_descriptor();
}

}  // namespace protobuf
}  // namespace google

// @@protoc_insertion_point(global_scope)

#endif  // PROTOBUF_INCLUDED_packet_5ftype_2eproto
