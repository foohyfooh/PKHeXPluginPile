using PKHeX.Core;

namespace PluginPile.Unmaintained.AutoModQRPlugins; 
/// <summary>
/// PGL Website QR Rental Team
/// </summary>
public class RentalTeam(byte[] data) {
  public readonly IReadOnlyList<QRPK7> Team = new QRPK7[] {
    new QRPK7(data[0x00..0x30]),
    new QRPK7(data[0x30..0x60]),
    new QRPK7(data[0x60..0x90]),
    new QRPK7(data[0x90..0xC0]),
    new QRPK7(data[0xC0..0xF0]),
    new QRPK7(data[0xF0..0x120]),
  };
  public IReadOnlyList<byte> GlobalLinkID { get; } = data[0x120..0x128];
  public IReadOnlyList<byte> UnknownData { get; } = data.AsSpan(0x128).ToArray();

  private static readonly SaveFile Dummy = new SAV7USUM();
  public IEnumerable<ShowdownSet> ConvertedTeam => Team.Select(z => z.ConvertToPKM(Dummy)).Select(z => new ShowdownSet(z));
}
