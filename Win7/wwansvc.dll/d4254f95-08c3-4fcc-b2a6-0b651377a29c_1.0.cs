//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\wwansvc.dll
// Interface ID: d4254f95-08c3-4fcc-b2a6-0b651377a29c
// Interface Version: 1.0



namespace rpc_d4254f95_08c3_4fcc_b2a6_0b651377a29c_1_0
{
    
    #region Marshal Helpers
    internal class _Marshal_Helper : NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer
    {
        public void Write_0(Struct_0 p0)
        {
            WriteStruct<Struct_0>(p0);
        }
        public void Write_1(Struct_2 p0)
        {
            WriteStruct<Struct_2>(p0);
        }
        public void Write_2(Struct_3 p0)
        {
            WriteStruct<Struct_3>(p0);
        }
        public void Write_3(Struct_4 p0)
        {
            WriteStruct<Struct_4>(p0);
        }
        public void Write_4(Struct_5 p0)
        {
            WriteStruct<Struct_5>(p0);
        }
        public void Write_5(Struct_6 p0)
        {
            WriteStruct<Struct_6>(p0);
        }
        public void Write_6(Struct_7 p0)
        {
            WriteStruct<Struct_7>(p0);
        }
        public void Write_7(Struct_8 p0)
        {
            WriteStruct<Struct_8>(p0);
        }
        public void Write_8(Struct_9 p0)
        {
            WriteStruct<Struct_9>(p0);
        }
        public void Write_9(sbyte[] p0, long p1)
        {
            WriteConformantArray<sbyte>(p0, p1);
        }
        public void Write_10(Struct_3[] p0, long p1)
        {
            WriteConformantArray<Struct_3>(p0, p1);
        }
        public void Write_11(string p0)
        {
            WriteFixedString(p0, 256);
        }
        public void Write_12(sbyte[] p0)
        {
            WriteFixedPrimitiveArray<sbyte>(p0, 16);
        }
        public void Write_13(Struct_9[] p0, long p1)
        {
            WriteConformantArray<Struct_9>(p0, p1);
        }
        public void Write_14(sbyte[] p0, long p1)
        {
            WriteConformantArray<sbyte>(p0, p1);
        }
        public void Write_15(sbyte[] p0, long p1)
        {
            WriteConformantArray<sbyte>(p0, p1);
        }
        public void Write_16(sbyte[] p0, long p1)
        {
            WriteConformantArray<sbyte>(p0, p1);
        }
    }
    internal class _Unmarshal_Helper : NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer
    {
        public _Unmarshal_Helper(NtApiDotNet.Win32.Rpc.RpcClientResponse r) : 
                base(r.NdrBuffer, r.Handles, r.DataRepresentation)
        {
        }
        public _Unmarshal_Helper(byte[] ba) : 
                base(ba)
        {
        }
        public Struct_0 Read_0()
        {
            return ReadStruct<Struct_0>();
        }
        public Struct_2 Read_1()
        {
            return ReadStruct<Struct_2>();
        }
        public Struct_3 Read_2()
        {
            return ReadStruct<Struct_3>();
        }
        public Struct_4 Read_3()
        {
            return ReadStruct<Struct_4>();
        }
        public Struct_5 Read_4()
        {
            return ReadStruct<Struct_5>();
        }
        public Struct_6 Read_5()
        {
            return ReadStruct<Struct_6>();
        }
        public Struct_7 Read_6()
        {
            return ReadStruct<Struct_7>();
        }
        public Struct_8 Read_7()
        {
            return ReadStruct<Struct_8>();
        }
        public Struct_9 Read_8()
        {
            return ReadStruct<Struct_9>();
        }
        public sbyte[] Read_9()
        {
            return ReadConformantArray<sbyte>();
        }
        public Struct_3[] Read_10()
        {
            return ReadConformantArray<Struct_3>();
        }
        public string Read_11()
        {
            return ReadFixedString(256);
        }
        public sbyte[] Read_12()
        {
            return ReadFixedPrimitiveArray<sbyte>(16);
        }
        public Struct_9[] Read_13()
        {
            return ReadConformantArray<Struct_9>();
        }
        public sbyte[] Read_14()
        {
            return ReadConformantArray<sbyte>();
        }
        public sbyte[] Read_15()
        {
            return ReadConformantArray<sbyte>();
        }
        public sbyte[] Read_16()
        {
            return ReadConformantArray<sbyte>();
        }
    }
    #endregion
    #region Complex Types
    public struct Struct_0 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.WriteInt32(Member4);
            m.WriteGuid(Member8);
            m.WriteInt32(Member18);
            m.WriteEmbeddedPointer<sbyte[], long>(Member20, new System.Action<sbyte[], long>(m.Write_9), Member18);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member4 = u.ReadInt32();
            Member8 = u.ReadGuid();
            Member18 = u.ReadInt32();
            Member20 = u.ReadEmbeddedPointer<sbyte[]>(new System.Func<sbyte[]>(u.Read_9), false);
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public int Member4;
        public System.Guid Member8;
        public int Member18;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<sbyte[]> Member20;
        public static Struct_0 CreateDefault()
        {
            return new Struct_0();
        }
        public Struct_0(int Member0, int Member4, System.Guid Member8, int Member18, sbyte[] Member20)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
            this.Member8 = Member8;
            this.Member18 = Member18;
            this.Member20 = Member20;
        }
    }
    public struct Struct_2 : NtApiDotNet.Ndr.Marshal.INdrConformantStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.Write_10(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member4, "Member4"), Member0);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member4 = u.Read_10();
        }
        int NtApiDotNet.Ndr.Marshal.INdrConformantStructure.GetConformantDimensions()
        {
            return 1;
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public Struct_3[] Member4;
        public static Struct_2 CreateDefault()
        {
            Struct_2 ret = new Struct_2();
            ret.Member4 = new Struct_3[0];
            return ret;
        }
        public Struct_2(int Member0, Struct_3[] Member4)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
        }
    }
    public struct Struct_3 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteGuid(Member0);
            m.Write_11(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member10, "Member10"));
            m.Write_3(Member210);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadGuid();
            Member10 = u.Read_11();
            Member210 = u.Read_3();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public System.Guid Member0;
        public string Member10;
        public Struct_4 Member210;
        public static Struct_3 CreateDefault()
        {
            Struct_3 ret = new Struct_3();
            ret.Member10 = new string('\0', 256);
            return ret;
        }
        public Struct_3(System.Guid Member0, string Member10, Struct_4 Member210)
        {
            this.Member0 = Member0;
            this.Member10 = Member10;
            this.Member210 = Member210;
        }
    }
    public struct Struct_4 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.WriteInt32(Member4);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member4 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public int Member4;
        public static Struct_4 CreateDefault()
        {
            return new Struct_4();
        }
        public Struct_4(int Member0, int Member4)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
        }
    }
    public struct Struct_5 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.Write_12(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member0, "Member0"));
            m.WriteEnum16(Member10);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.Read_12();
            Member10 = u.ReadEnum16();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 2;
        }
        public sbyte[] Member0;
        public NtApiDotNet.Ndr.Marshal.NdrEnum16 Member10;
        public static Struct_5 CreateDefault()
        {
            Struct_5 ret = new Struct_5();
            ret.Member0 = new sbyte[16];
            return ret;
        }
        public Struct_5(sbyte[] Member0, NtApiDotNet.Ndr.Marshal.NdrEnum16 Member10)
        {
            this.Member0 = Member0;
            this.Member10 = Member10;
        }
    }
    public struct Struct_6 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteEnum16(Member0);
            m.Write_6(Member4);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadEnum16();
            Member4 = u.Read_6();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public NtApiDotNet.Ndr.Marshal.NdrEnum16 Member0;
        public Struct_7 Member4;
        public static Struct_6 CreateDefault()
        {
            return new Struct_6();
        }
        public Struct_6(NtApiDotNet.Ndr.Marshal.NdrEnum16 Member0, Struct_7 Member4)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
        }
    }
    public struct Struct_7 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteEnum16(Member0);
            m.WriteInt32(Member4);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadEnum16();
            Member4 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public NtApiDotNet.Ndr.Marshal.NdrEnum16 Member0;
        public int Member4;
        public static Struct_7 CreateDefault()
        {
            return new Struct_7();
        }
        public Struct_7(NtApiDotNet.Ndr.Marshal.NdrEnum16 Member0, int Member4)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
        }
    }
    public struct Struct_8 : NtApiDotNet.Ndr.Marshal.INdrConformantStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.Write_13(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member4, "Member4"), Member0);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member4 = u.Read_13();
        }
        int NtApiDotNet.Ndr.Marshal.INdrConformantStructure.GetConformantDimensions()
        {
            return 1;
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public Struct_9[] Member4;
        public static Struct_8 CreateDefault()
        {
            Struct_8 ret = new Struct_8();
            ret.Member4 = new Struct_9[0];
            return ret;
        }
        public Struct_8(int Member0, Struct_9[] Member4)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
        }
    }
    public struct Struct_9 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.Write_11(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member0, "Member0"));
            m.WriteInt32(Member200);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.Read_11();
            Member200 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public string Member0;
        public int Member200;
        public static Struct_9 CreateDefault()
        {
            Struct_9 ret = new Struct_9();
            ret.Member0 = new string('\0', 256);
            return ret;
        }
        public Struct_9(string Member0, int Member200)
        {
            this.Member0 = Member0;
            this.Member200 = Member200;
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("d4254f95-08c3-4fcc-b2a6-0b651377a29c", 1, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public int WwanRpcOpenHandle(char p0, int p1, int p2, ref int p3, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteChar(p0);
            m.WriteInt32(p1);
            m.WriteInt32(p2);
            m.WriteInt32(p3);
            _Unmarshal_Helper u = SendReceive(0, m);
            p3 = u.ReadInt32();
            p4 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int WwanRpcCloseHandle(ref NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(1, m);
            p0 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int WwanRpcRegisterNotification(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, out int p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt32(p1);
            _Unmarshal_Helper u = SendReceive(2, m);
            p2 = u.ReadInt32();
            return u.ReadInt32();
        }
        // async
        public int WwanRpcAsyncGetNotification(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out System.Nullable<Struct_0> p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(3, m);
            p1 = u.ReadReferentValue<Struct_0>(new System.Func<Struct_0>(u.Read_0), false);
            return u.ReadInt32();
        }
        public int WwanRpcEnumerateInterfaces(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out System.Nullable<Struct_2> p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(4, m);
            p1 = u.ReadReferentValue<Struct_2>(new System.Func<Struct_2>(u.Read_1), false);
            return u.ReadInt32();
        }
        public int WwanRpcSetInterface(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, System.Guid p1, NtApiDotNet.Ndr.Marshal.NdrEnum16 p2, int p3, sbyte[] p4, ref System.Nullable<int> p5, ref System.Nullable<int> p6)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteGuid(p1);
            m.WriteEnum16(p2);
            m.WriteInt32(p3);
            m.Write_14(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p4, "p4"), p3);
            m.WriteReferent(p5, new System.Action<int>(m.WriteInt32));
            m.WriteReferent(p6, new System.Action<int>(m.WriteInt32));
            _Unmarshal_Helper u = SendReceive(5, m);
            p5 = u.ReadReferentValue<int>(new System.Func<int>(u.ReadInt32), false);
            p6 = u.ReadReferentValue<int>(new System.Func<int>(u.ReadInt32), false);
            return u.ReadInt32();
        }
        public int WwanRpcQueryInterface(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, System.Guid p1, NtApiDotNet.Ndr.Marshal.NdrEnum16 p2, out int p3, out sbyte[] p4, ref System.Nullable<int> p5, ref System.Nullable<int> p6)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteGuid(p1);
            m.WriteEnum16(p2);
            m.WriteReferent(p5, new System.Action<int>(m.WriteInt32));
            m.WriteReferent(p6, new System.Action<int>(m.WriteInt32));
            _Unmarshal_Helper u = SendReceive(6, m);
            p3 = u.ReadInt32();
            p4 = u.ReadReferent<sbyte[]>(new System.Func<sbyte[]>(u.Read_15), false);
            p5 = u.ReadReferentValue<int>(new System.Func<int>(u.ReadInt32), false);
            p6 = u.ReadReferentValue<int>(new System.Func<int>(u.ReadInt32), false);
            return u.ReadInt32();
        }
        public int WwanRpcScan(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, System.Guid p1, ref System.Nullable<int> p2, ref System.Nullable<int> p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteGuid(p1);
            m.WriteReferent(p2, new System.Action<int>(m.WriteInt32));
            m.WriteReferent(p3, new System.Action<int>(m.WriteInt32));
            _Unmarshal_Helper u = SendReceive(7, m);
            p2 = u.ReadReferentValue<int>(new System.Func<int>(u.ReadInt32), false);
            p3 = u.ReadReferentValue<int>(new System.Func<int>(u.ReadInt32), false);
            return u.ReadInt32();
        }
        public int WwanRpcRegister(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, System.Guid p1, NtApiDotNet.Ndr.Marshal.NdrEnum16 p2, string p3, int p4, ref System.Nullable<int> p5, ref System.Nullable<int> p6)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteGuid(p1);
            m.WriteEnum16(p2);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p3, "p3"));
            m.WriteInt32(p4);
            m.WriteReferent(p5, new System.Action<int>(m.WriteInt32));
            m.WriteReferent(p6, new System.Action<int>(m.WriteInt32));
            _Unmarshal_Helper u = SendReceive(8, m);
            p5 = u.ReadReferentValue<int>(new System.Func<int>(u.ReadInt32), false);
            p6 = u.ReadReferentValue<int>(new System.Func<int>(u.ReadInt32), false);
            return u.ReadInt32();
        }
        public int WwanRpcConnect(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, System.Guid p1, NtApiDotNet.Ndr.Marshal.NdrEnum16 p2, string p3, System.Guid p4, out int p5, ref System.Nullable<int> p6)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteGuid(p1);
            m.WriteEnum16(p2);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p3, "p3"));
            m.WriteGuid(p4);
            m.WriteReferent(p6, new System.Action<int>(m.WriteInt32));
            _Unmarshal_Helper u = SendReceive(9, m);
            p5 = u.ReadInt32();
            p6 = u.ReadReferentValue<int>(new System.Func<int>(u.ReadInt32), false);
            return u.ReadInt32();
        }
        public int WwanRpcDisconnect(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, System.Guid p1, int p2, ref System.Nullable<int> p3, ref System.Nullable<int> p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteGuid(p1);
            m.WriteInt32(p2);
            m.WriteReferent(p3, new System.Action<int>(m.WriteInt32));
            m.WriteReferent(p4, new System.Action<int>(m.WriteInt32));
            _Unmarshal_Helper u = SendReceive(10, m);
            p3 = u.ReadReferentValue<int>(new System.Func<int>(u.ReadInt32), false);
            p4 = u.ReadReferentValue<int>(new System.Func<int>(u.ReadInt32), false);
            return u.ReadInt32();
        }
        public int WwanRpcSetSmsConfiguration(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, System.Guid p1, Struct_5 p2, ref System.Nullable<int> p3, ref System.Nullable<int> p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteGuid(p1);
            m.Write_4(p2);
            m.WriteReferent(p3, new System.Action<int>(m.WriteInt32));
            m.WriteReferent(p4, new System.Action<int>(m.WriteInt32));
            _Unmarshal_Helper u = SendReceive(11, m);
            p3 = u.ReadReferentValue<int>(new System.Func<int>(u.ReadInt32), false);
            p4 = u.ReadReferentValue<int>(new System.Func<int>(u.ReadInt32), false);
            return u.ReadInt32();
        }
        public int WwanRpcSmsRead(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, System.Guid p1, Struct_6 p2, ref System.Nullable<int> p3, ref System.Nullable<int> p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteGuid(p1);
            m.Write_5(p2);
            m.WriteReferent(p3, new System.Action<int>(m.WriteInt32));
            m.WriteReferent(p4, new System.Action<int>(m.WriteInt32));
            _Unmarshal_Helper u = SendReceive(12, m);
            p3 = u.ReadReferentValue<int>(new System.Func<int>(u.ReadInt32), false);
            p4 = u.ReadReferentValue<int>(new System.Func<int>(u.ReadInt32), false);
            return u.ReadInt32();
        }
        public int WwanRpcSmsSend(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, System.Guid p1, NtApiDotNet.Ndr.Marshal.NdrEnum16 p2, int p3, sbyte[] p4, ref System.Nullable<int> p5, ref System.Nullable<int> p6)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteGuid(p1);
            m.WriteEnum16(p2);
            m.WriteInt32(p3);
            m.Write_14(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p4, "p4"), p3);
            m.WriteReferent(p5, new System.Action<int>(m.WriteInt32));
            m.WriteReferent(p6, new System.Action<int>(m.WriteInt32));
            _Unmarshal_Helper u = SendReceive(13, m);
            p5 = u.ReadReferentValue<int>(new System.Func<int>(u.ReadInt32), false);
            p6 = u.ReadReferentValue<int>(new System.Func<int>(u.ReadInt32), false);
            return u.ReadInt32();
        }
        public int WwanRpcSmsDelete(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, System.Guid p1, Struct_7 p2, ref System.Nullable<int> p3, ref System.Nullable<int> p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteGuid(p1);
            m.Write_6(p2);
            m.WriteReferent(p3, new System.Action<int>(m.WriteInt32));
            m.WriteReferent(p4, new System.Action<int>(m.WriteInt32));
            _Unmarshal_Helper u = SendReceive(14, m);
            p3 = u.ReadReferentValue<int>(new System.Func<int>(u.ReadInt32), false);
            p4 = u.ReadReferentValue<int>(new System.Func<int>(u.ReadInt32), false);
            return u.ReadInt32();
        }
        public int WwanRpcSetProfile(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, System.Guid p1, int p2, string p3, int p4, ref System.Nullable<int> p5, out NtApiDotNet.Ndr.Marshal.NdrEnum16 p6)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteGuid(p1);
            m.WriteInt32(p2);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p3, "p3"));
            m.WriteInt32(p4);
            m.WriteReferent(p5, new System.Action<int>(m.WriteInt32));
            _Unmarshal_Helper u = SendReceive(15, m);
            p5 = u.ReadReferentValue<int>(new System.Func<int>(u.ReadInt32), false);
            p6 = u.ReadEnum16();
            return u.ReadInt32();
        }
        public int WwanRpcDeleteProfile(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, System.Guid p1, string p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteGuid(p1);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p2, "p2"));
            _Unmarshal_Helper u = SendReceive(16, m);
            return u.ReadInt32();
        }
        public int WwanRpcGetProfile(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, System.Guid p1, string p2, out string p3, ref System.Nullable<int> p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteGuid(p1);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p2, "p2"));
            m.WriteReferent(p4, new System.Action<int>(m.WriteInt32));
            _Unmarshal_Helper u = SendReceive(17, m);
            p3 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            p4 = u.ReadReferentValue<int>(new System.Func<int>(u.ReadInt32), false);
            return u.ReadInt32();
        }
        public int WwanRpcGetProfileList(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, System.Guid p1, out System.Nullable<Struct_8> p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteGuid(p1);
            _Unmarshal_Helper u = SendReceive(18, m);
            p2 = u.ReadReferentValue<Struct_8>(new System.Func<Struct_8>(u.Read_7), false);
            return u.ReadInt32();
        }
        public int WwanRpcGetProfileIstream(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, string p1, out int p2, out sbyte[] p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
            _Unmarshal_Helper u = SendReceive(19, m);
            p2 = u.ReadInt32();
            p3 = u.ReadReferent<sbyte[]>(new System.Func<sbyte[]>(u.Read_16), false);
            return u.ReadInt32();
        }
    }
    #endregion
}

