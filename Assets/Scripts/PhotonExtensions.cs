using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

using Photon.Pun;
using Photon.Realtime;

public static class PhotonExtensions {

    private static readonly Dictionary<string, string> SPECIAL_PLAYERS = new() {
        ["cf03abdb5d2ef1b6f0d30ae40303936f9ab22f387f8a1072e2849c8292470af1"] = "ipodtouch0218",
        ["3aa94db78bfd45afc8092eb6eae7c0268cb95b23f277a44feced25a9d4121a1f"] = "miyavmeow",
        ["d1f4c667f608b97aad4d05083651a22d7b6e6cc7d7ea8fb494c302d62c8a807c"] = "miyavmeow",
    };

    public static bool IsMineOrLocal(this PhotonView view) {
        return !view || view.IsMine;
    }

    public static bool HasRainbowName(this Player player) {
        if (player == null || player.UserId == null)
            return false;

        byte[] bytes = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(player.UserId));
        StringBuilder sb = new();
        foreach (byte b in bytes)
            sb.Append(b.ToString("X2"));

        string hash = sb.ToString().ToLower();
        return SPECIAL_PLAYERS.ContainsKey(hash) && player.NickName == SPECIAL_PLAYERS[hash];
    }

    //public static void RPCFunc(this PhotonView view, Delegate action, RpcTarget target, params object[] parameters) {
    //    view.RPC(nameof(action), target, parameters);
    //}
}