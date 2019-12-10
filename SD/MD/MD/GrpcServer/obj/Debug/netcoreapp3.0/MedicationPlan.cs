// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/medicationPlan.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace GrpcServer {

  /// <summary>Holder for reflection information generated from Protos/medicationPlan.proto</summary>
  public static partial class MedicationPlanReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/medicationPlan.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MedicationPlanReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtQcm90b3MvbWVkaWNhdGlvblBsYW4ucHJvdG8iHQoNUmV0dXJuTWVzc2Fn",
            "ZRIMCgRET05FGAEgASgIIiAKDU1QRnJvbVBhdGllbnQSDwoHcGF0aWVudBgB",
            "IAEoBSIWCghEZWxldGVNUBIKCgJpZBgBIAEoBSJhCgdNUE1vZGVsEgoKAmlk",
            "GAEgASgFEg8KB3BhdGllbnQYAiABKAUSEgoKbWVkaWNhdGlvbhgDIAEoBRIX",
            "Cg9tZWRpY2F0aW9uX3BsYW4YBCABKAUSDAoEdGltZRgFIAEoCSJWCgtSZXBv",
            "cnRNb2RlbBIKCgJpZBgBIAEoBRIPCgdwYXRpZW50GAIgASgFEhsKE21lZGlj",
            "YXRpb25fc2NoZWR1bGUYAyABKAUSDQoFdGFrZW4YBCABKAgyqgEKDk1lZGlj",
            "YXRpb25QbGFuEjEKFERlbGV0ZU1lZGljYXRpb25QbGFuEgkuRGVsZXRlTVAa",
            "Di5SZXR1cm5NZXNzYWdlEjoKHEdldE1lZGljYXRpb25QbGFuRnJvbVBhdGll",
            "bnQSDi5NUEZyb21QYXRpZW50GgguTVBNb2RlbDABEikKCUFkZFJlcG9ydBIM",
            "LlJlcG9ydE1vZGVsGg4uUmV0dXJuTWVzc2FnZUINqgIKR3JwY1NlcnZlcmIG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcServer.ReturnMessage), global::GrpcServer.ReturnMessage.Parser, new[]{ "DONE" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcServer.MPFromPatient), global::GrpcServer.MPFromPatient.Parser, new[]{ "Patient" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcServer.DeleteMP), global::GrpcServer.DeleteMP.Parser, new[]{ "Id" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcServer.MPModel), global::GrpcServer.MPModel.Parser, new[]{ "Id", "Patient", "Medication", "MedicationPlan", "Time" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcServer.ReportModel), global::GrpcServer.ReportModel.Parser, new[]{ "Id", "Patient", "MedicationSchedule", "Taken" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ReturnMessage : pb::IMessage<ReturnMessage> {
    private static readonly pb::MessageParser<ReturnMessage> _parser = new pb::MessageParser<ReturnMessage>(() => new ReturnMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ReturnMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcServer.MedicationPlanReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReturnMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReturnMessage(ReturnMessage other) : this() {
      dONE_ = other.dONE_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReturnMessage Clone() {
      return new ReturnMessage(this);
    }

    /// <summary>Field number for the "DONE" field.</summary>
    public const int DONEFieldNumber = 1;
    private bool dONE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool DONE {
      get { return dONE_; }
      set {
        dONE_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ReturnMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ReturnMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (DONE != other.DONE) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (DONE != false) hash ^= DONE.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (DONE != false) {
        output.WriteRawTag(8);
        output.WriteBool(DONE);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (DONE != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ReturnMessage other) {
      if (other == null) {
        return;
      }
      if (other.DONE != false) {
        DONE = other.DONE;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            DONE = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  public sealed partial class MPFromPatient : pb::IMessage<MPFromPatient> {
    private static readonly pb::MessageParser<MPFromPatient> _parser = new pb::MessageParser<MPFromPatient>(() => new MPFromPatient());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MPFromPatient> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcServer.MedicationPlanReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MPFromPatient() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MPFromPatient(MPFromPatient other) : this() {
      patient_ = other.patient_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MPFromPatient Clone() {
      return new MPFromPatient(this);
    }

    /// <summary>Field number for the "patient" field.</summary>
    public const int PatientFieldNumber = 1;
    private int patient_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Patient {
      get { return patient_; }
      set {
        patient_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MPFromPatient);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MPFromPatient other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Patient != other.Patient) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Patient != 0) hash ^= Patient.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Patient != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Patient);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Patient != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Patient);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MPFromPatient other) {
      if (other == null) {
        return;
      }
      if (other.Patient != 0) {
        Patient = other.Patient;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Patient = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class DeleteMP : pb::IMessage<DeleteMP> {
    private static readonly pb::MessageParser<DeleteMP> _parser = new pb::MessageParser<DeleteMP>(() => new DeleteMP());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DeleteMP> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcServer.MedicationPlanReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DeleteMP() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DeleteMP(DeleteMP other) : this() {
      id_ = other.id_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DeleteMP Clone() {
      return new DeleteMP(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private int id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DeleteMP);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DeleteMP other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Id);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DeleteMP other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Id = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class MPModel : pb::IMessage<MPModel> {
    private static readonly pb::MessageParser<MPModel> _parser = new pb::MessageParser<MPModel>(() => new MPModel());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MPModel> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcServer.MedicationPlanReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MPModel() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MPModel(MPModel other) : this() {
      id_ = other.id_;
      patient_ = other.patient_;
      medication_ = other.medication_;
      medicationPlan_ = other.medicationPlan_;
      time_ = other.time_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MPModel Clone() {
      return new MPModel(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private int id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "patient" field.</summary>
    public const int PatientFieldNumber = 2;
    private int patient_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Patient {
      get { return patient_; }
      set {
        patient_ = value;
      }
    }

    /// <summary>Field number for the "medication" field.</summary>
    public const int MedicationFieldNumber = 3;
    private int medication_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Medication {
      get { return medication_; }
      set {
        medication_ = value;
      }
    }

    /// <summary>Field number for the "medication_plan" field.</summary>
    public const int MedicationPlanFieldNumber = 4;
    private int medicationPlan_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int MedicationPlan {
      get { return medicationPlan_; }
      set {
        medicationPlan_ = value;
      }
    }

    /// <summary>Field number for the "time" field.</summary>
    public const int TimeFieldNumber = 5;
    private string time_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Time {
      get { return time_; }
      set {
        time_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MPModel);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MPModel other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Patient != other.Patient) return false;
      if (Medication != other.Medication) return false;
      if (MedicationPlan != other.MedicationPlan) return false;
      if (Time != other.Time) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      if (Patient != 0) hash ^= Patient.GetHashCode();
      if (Medication != 0) hash ^= Medication.GetHashCode();
      if (MedicationPlan != 0) hash ^= MedicationPlan.GetHashCode();
      if (Time.Length != 0) hash ^= Time.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Id);
      }
      if (Patient != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Patient);
      }
      if (Medication != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Medication);
      }
      if (MedicationPlan != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(MedicationPlan);
      }
      if (Time.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Time);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      if (Patient != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Patient);
      }
      if (Medication != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Medication);
      }
      if (MedicationPlan != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MedicationPlan);
      }
      if (Time.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Time);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MPModel other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.Patient != 0) {
        Patient = other.Patient;
      }
      if (other.Medication != 0) {
        Medication = other.Medication;
      }
      if (other.MedicationPlan != 0) {
        MedicationPlan = other.MedicationPlan;
      }
      if (other.Time.Length != 0) {
        Time = other.Time;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Id = input.ReadInt32();
            break;
          }
          case 16: {
            Patient = input.ReadInt32();
            break;
          }
          case 24: {
            Medication = input.ReadInt32();
            break;
          }
          case 32: {
            MedicationPlan = input.ReadInt32();
            break;
          }
          case 42: {
            Time = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class ReportModel : pb::IMessage<ReportModel> {
    private static readonly pb::MessageParser<ReportModel> _parser = new pb::MessageParser<ReportModel>(() => new ReportModel());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ReportModel> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcServer.MedicationPlanReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReportModel() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReportModel(ReportModel other) : this() {
      id_ = other.id_;
      patient_ = other.patient_;
      medicationSchedule_ = other.medicationSchedule_;
      taken_ = other.taken_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReportModel Clone() {
      return new ReportModel(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private int id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "patient" field.</summary>
    public const int PatientFieldNumber = 2;
    private int patient_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Patient {
      get { return patient_; }
      set {
        patient_ = value;
      }
    }

    /// <summary>Field number for the "medication_schedule" field.</summary>
    public const int MedicationScheduleFieldNumber = 3;
    private int medicationSchedule_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int MedicationSchedule {
      get { return medicationSchedule_; }
      set {
        medicationSchedule_ = value;
      }
    }

    /// <summary>Field number for the "taken" field.</summary>
    public const int TakenFieldNumber = 4;
    private bool taken_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Taken {
      get { return taken_; }
      set {
        taken_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ReportModel);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ReportModel other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Patient != other.Patient) return false;
      if (MedicationSchedule != other.MedicationSchedule) return false;
      if (Taken != other.Taken) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      if (Patient != 0) hash ^= Patient.GetHashCode();
      if (MedicationSchedule != 0) hash ^= MedicationSchedule.GetHashCode();
      if (Taken != false) hash ^= Taken.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Id);
      }
      if (Patient != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Patient);
      }
      if (MedicationSchedule != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(MedicationSchedule);
      }
      if (Taken != false) {
        output.WriteRawTag(32);
        output.WriteBool(Taken);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      if (Patient != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Patient);
      }
      if (MedicationSchedule != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MedicationSchedule);
      }
      if (Taken != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ReportModel other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.Patient != 0) {
        Patient = other.Patient;
      }
      if (other.MedicationSchedule != 0) {
        MedicationSchedule = other.MedicationSchedule;
      }
      if (other.Taken != false) {
        Taken = other.Taken;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Id = input.ReadInt32();
            break;
          }
          case 16: {
            Patient = input.ReadInt32();
            break;
          }
          case 24: {
            MedicationSchedule = input.ReadInt32();
            break;
          }
          case 32: {
            Taken = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
