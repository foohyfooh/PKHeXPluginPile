namespace PluginPile.Unmaintained.BWTool; 
public class TrainerRecords(byte[] data) {
  private readonly byte[] Data = data;

  // General Card Properties
  public uint WildCount {
    get => BitConverter.ToUInt32(Data, 0x14);
    set => BitConverter.GetBytes(value).CopyTo(Data, 0x14);
  }

  public uint TrBattles {
    get => BitConverter.ToUInt32(Data, 0x18);
    set => BitConverter.GetBytes(value).CopyTo(Data, 0x18);
  }

  public ushort Feelings {
    get => BitConverter.ToUInt16(Data, 0x170);
    set => BitConverter.GetBytes(value).CopyTo(Data, 0x170);
  }

  public ushort Musical {
    get => BitConverter.ToUInt16(Data, 0x172);
    set => BitConverter.GetBytes(value).CopyTo(Data, 0x172);
  }

  public ushort BattleTest {
    get => BitConverter.ToUInt16(Data, 0x186);
    set => BitConverter.GetBytes(value).CopyTo(Data, 0x186);
  }

  public ushort MovieShoots {
    get => BitConverter.ToUInt16(Data, 0x194);
    set => BitConverter.GetBytes(value).CopyTo(Data, 0x194);
  }

  public ushort Customers {
    get => BitConverter.ToUInt16(Data, 0x18C);
    set => BitConverter.GetBytes(value).CopyTo(Data, 0x18C);
  }

  public ushort BattleWins {
    get => BitConverter.ToUInt16(Data, 0x120);
    set => BitConverter.GetBytes(value).CopyTo(Data, 0x120);
  }

  public ushort BattleLoses {
    get => BitConverter.ToUInt16(Data, 0x4C);
    set => BitConverter.GetBytes(value).CopyTo(Data, 0x4C);
  }
}
