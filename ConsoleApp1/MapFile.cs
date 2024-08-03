using System.Collections.Generic;

namespace Kaitai
{
    public partial class MapFile : KaitaiStruct
    {
        public static MapFile FromFile(string fileName)
        {
            return new MapFile(new KaitaiStream(fileName));
        }

        public MapFile(KaitaiStream p__io, KaitaiStruct p__parent = null, MapFile p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _headerId = m_io.ReadU4le();
            _radarMapCompressedSize = m_io.ReadU4le();
            _radarMapData = System.Text.Encoding.GetEncoding("ascii").GetString(m_io.ReadBytes(RadarMapCompressedSize));
            _num7 = m_io.ReadU4le();
            _missionTextType = m_io.ReadU4le();
            _missionTextNumber = m_io.ReadU4le();
            _ansiMissionText = System.Text.Encoding.GetEncoding("ascii").GetString(m_io.ReadBytes((Num7 - 8)));
            _nextNum7 = m_io.ReadU4le();
            _xplaySaveTime = m_io.ReadU4le();
            _xplaySaveChecksum = m_io.ReadU4le();
            _additionalNum7 = m_io.ReadU4le();
            _mapType = m_io.ReadU4le();
            _mapKeeps = new List<uint>();
            for (var i = 0; i < 5; i++)
            {
                _mapKeeps.Add(m_io.ReadU4le());
            }
            _maxPlayers = m_io.ReadU4le();
            _nextAdditionalNum7 = m_io.ReadU4le();
            _scnMissionType = m_io.ReadU4le();
            _scnMissionSiegeOrInvasion = m_io.ReadU4le();
            _missionLockType = m_io.ReadU4le();
            _standAloneFilename = System.Text.Encoding.GetEncoding("ascii").GetString(m_io.ReadBytes((AdditionalNum7 - 12)));
            _achFood = m_io.ReadU2le();
            _achWeapons = m_io.ReadU2le();
            _achWood = m_io.ReadU2le();
            _isKingOfTheHill = m_io.ReadU4le();
            _isSiegeThat = m_io.ReadU4le();
            _xplayAutoSave = m_io.ReadU4le();
        }
        private uint _headerId;
        private uint _radarMapCompressedSize;
        private string _radarMapData;
        private uint _num7;
        private uint _missionTextType;
        private uint _missionTextNumber;
        private string _ansiMissionText;
        private uint _nextNum7;
        private uint _xplaySaveTime;
        private uint _xplaySaveChecksum;
        private uint _additionalNum7;
        private uint _mapType;
        private List<uint> _mapKeeps;
        private uint _maxPlayers;
        private uint _nextAdditionalNum7;
        private uint _scnMissionType;
        private uint _scnMissionSiegeOrInvasion;
        private uint _missionLockType;
        private string _standAloneFilename;
        private ushort _achFood;
        private ushort _achWeapons;
        private ushort _achWood;
        private uint _isKingOfTheHill;
        private uint _isSiegeThat;
        private uint _xplayAutoSave;
        private MapFile m_root;
        private KaitaiStruct m_parent;
        public uint HeaderId { get { return _headerId; } }
        public uint RadarMapCompressedSize { get { return _radarMapCompressedSize; } }
        public string RadarMapData { get { return _radarMapData; } }
        public uint Num7 { get { return _num7; } }
        public uint MissionTextType { get { return _missionTextType; } }
        public uint MissionTextNumber { get { return _missionTextNumber; } }
        public string AnsiMissionText { get { return _ansiMissionText; } }
        public uint NextNum7 { get { return _nextNum7; } }
        public uint XplaySaveTime { get { return _xplaySaveTime; } }
        public uint XplaySaveChecksum { get { return _xplaySaveChecksum; } }
        public uint AdditionalNum7 { get { return _additionalNum7; } }
        public uint MapType { get { return _mapType; } }
        public List<uint> MapKeeps { get { return _mapKeeps; } }
        public uint MaxPlayers { get { return _maxPlayers; } }
        public uint NextAdditionalNum7 { get { return _nextAdditionalNum7; } }
        public uint ScnMissionType { get { return _scnMissionType; } }
        public uint ScnMissionSiegeOrInvasion { get { return _scnMissionSiegeOrInvasion; } }
        public uint MissionLockType { get { return _missionLockType; } }
        public string StandAloneFilename { get { return _standAloneFilename; } }
        public ushort AchFood { get { return _achFood; } }
        public ushort AchWeapons { get { return _achWeapons; } }
        public ushort AchWood { get { return _achWood; } }
        public uint IsKingOfTheHill { get { return _isKingOfTheHill; } }
        public uint IsSiegeThat { get { return _isSiegeThat; } }
        public uint XplayAutoSave { get { return _xplayAutoSave; } }
        public MapFile M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}