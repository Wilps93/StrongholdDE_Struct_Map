using System;
using System.IO;
using Kaitai;

class Program
{
    static void Main()
    {
        string[] localLowFiles = Directory.GetFiles(
            @"c:\users\wilps\appdata\locallow\firefly studios\stronghold 1 definitive edition\maps", "*.map");

        string[] steamFiles = Directory.GetFiles(
            @"c:\program files (x86)\steam\steamapps\common\stronghold definitive edition\stronghold 1 definitive edition_data\streamingassets\maps", "*.map");

        string saveFile = @"c:\users\wilps\appdata\locallow\firefly studios\stronghold 1 definitive edition\saves\1.sav";

        Console.WriteLine("Processing Local Low files...");
        foreach (string file in localLowFiles)
        {
            ProcessFile(file);
        }

        Console.WriteLine("Processing Steam files...");
        foreach (string file in steamFiles)
        {
            ProcessFile(file);
        }

        Console.WriteLine("Processing Save file...");
        ProcessFile(saveFile);
    }

    static void ProcessFile(string filePath)
    {
        try
        {
            var mapFile = MapFile.FromFile(filePath);
            DisplayFileInfo(filePath, mapFile);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Failed to process file {filePath}: {ex.Message}");
        }
    }

    static void DisplayFileInfo(string filePath, MapFile mapFile)
    {
        Console.WriteLine($"File: {Path.GetFileName(filePath)}");
        Console.WriteLine($"HeaderID: {mapFile.HeaderId:X8}");
        Console.WriteLine($"RadarMapCompressedSize: {mapFile.RadarMapCompressedSize} bytes");
        // Console.WriteLine($"RadarMapData: {mapFile.RadarMapData}"); // Убрано по вашему запросу
        Console.WriteLine($"Num7: {mapFile.Num7}");
        Console.WriteLine($"MissionTextType: {mapFile.MissionTextType}");
        Console.WriteLine($"MissionTextNumber: {mapFile.MissionTextNumber}");
		// Console.WriteLine($"AnsiMissionText: {mapFile.AnsiMissionText}");
        Console.WriteLine($"NextNum7: {mapFile.NextNum7}");
        Console.WriteLine($"XPlaySaveTime: {mapFile.XplaySaveTime}");
        Console.WriteLine($"XPlaySaveChecksum: {mapFile.XplaySaveChecksum}");
        Console.WriteLine($"AdditionalNum7: {mapFile.AdditionalNum7}");
        Console.WriteLine($"MapType: {mapFile.MapType}");
        Console.WriteLine($"MapKeeps: {string.Join(", ", mapFile.MapKeeps)}");
        Console.WriteLine($"MaxPlayers: {mapFile.MaxPlayers}");
        Console.WriteLine($"NextAdditionalNum7: {mapFile.NextAdditionalNum7}");
        Console.WriteLine($"ScnMissionType: {mapFile.ScnMissionType}");
        Console.WriteLine($"ScnMissionSiegeOrInvasion: {mapFile.ScnMissionSiegeOrInvasion}");
        Console.WriteLine($"MissionLockType: {mapFile.MissionLockType}");
        Console.WriteLine($"StandAloneFilename: {mapFile.StandAloneFilename}");
        Console.WriteLine($"AchFood: {mapFile.AchFood}");
        Console.WriteLine($"AchWeapons: {mapFile.AchWeapons}");
        Console.WriteLine($"AchWood: {mapFile.AchWood}");
        Console.WriteLine($"IsKingOfTheHill: {mapFile.IsKingOfTheHill}");
        Console.WriteLine($"IsSiegeThat: {mapFile.IsSiegeThat}");
        Console.WriteLine($"XPlayAutoSave: {mapFile.XplayAutoSave}");
    }
}
