namespace WDE.Common.DBC
{
    public interface IDbcIterator
    {
        uint Key { get; }
        public int GetInt(int field);
        public uint GetUInt(int field);
        public uint GetUInt(int field, int index);
        public ushort GetUShort(int field, int index);
        public ushort GetUShort(int field);
        public string GetString(int field);
        public float GetFloat(int field);
    }

    public interface IWdcIterator
    {
        public int Id { get; }
        public byte GetByte(string field);
        public byte GetByte(string field, int arrayIndex);
        public sbyte GetSByte(string field);
        public sbyte GetSByte(string field, int arrayIndex);
        public int GetInt(string field);
        public int GetInt(string field, int arrayIndex);
        public uint GetUInt(string field);
        public uint GetUInt(string field, int arrayIndex);
        public short GetShort(string field);
        public short GetShort(string field, int arrayIndex);
        public ushort GetUShort(string field);
        public ushort GetUShort(string field, int arrayIndex);
        public string GetString(string field);
        public string GetString(string field, int arrayIndex);
        public float GetFloat(string field);
        public float GetFloat(string field, int arrayIndex);
    }
}