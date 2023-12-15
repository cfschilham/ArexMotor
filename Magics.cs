﻿namespace BughouseChess.Core;

public static class Magics
{
    public static readonly ulong[] Bishop14 = // 14-bit magics. Works for blockerMask * magic >> 50
    {
        0xb0d225790e352e2e,
        0x5c29f3c4d966533a,
        0x405c7a0aaafa1792,
        0xe0bf4d8d804a2a60,
        0x774a6074cfc73202,
        0x9a3586d4037f8565,
        0x4f2676f7fac43e93,
        0xbe438e7bb2483cc1,
        0x2340fdb65930a8ec,
        0x1a0621b5a301c7c2,
        0xcfe11632f79d438c,
        0x62b66cdf0f55429b,
        0x60a66a4469b87a37,
        0x848b28e3eee32fc6,
        0x95b28f7f28d339a5,
        0xb855c01622ea181a,
        0xb284ba6d7d225530,
        0x55e712ec17df32f2,
        0x6ac6295d167f5e94,
        0x1caa6f79c0af4ad,
        0x80000c8ecc059841,
        0x7ffffef62df94324,
        0x6cc255ac74774100,
        0xb053d9171b8d200,
        0xa86c00be17615980,
        0x68a6a03edfba7200,
        0x3baca6f281ae6818,
        0x1223ca7ef4ee,
        0x1fa681465a0f4000,
        0x8d2f383efd9be000,
        0xa392a0622d41000,
        0xd9245831d803b900,
        0x5c9167475db22e00,
        0xa5f84213f769f200,
        0xd404dca38b63be00,
        0x3ffffd5938970600,
        0xb5dc040c9a00,
        0xfe85827678d4dd00,
        0x7255fc17096dd800,
        0x68530161b0877040,
        0x9088fb522f7ad800,
        0xbf937316b0fbc200,
        0x79c81690b643f100,
        0x1658c5ac8f1a7c80,
        0x79ca8b018d75d700,
        0x519e2fd179d1b280,
        0x91bab5c087d3be80,
        0x4b3d54d1081a4110,
        0x8a4b9166622c2080,
        0x56694190edc80c70,
        0x5ee0c6cde2b30c62,
        0xc3bc1cbf76e83220,
        0x4c57a486023af600,
        0xd6f6e907e8809980,
        0x9fe1a78d20b67e00,
        0x1c8f1e7432ab1d48,
        0x2eabcc8ed8dd8900,
        0x654c37391a7f8df8,
        0x7ce2bbd3ba171480,
        0x9486a8be9e0502e0,
        0x3b5cbdf18be0170,
        0x6e518cd7bdd52b60,
        0xc749cf4c630f34a0,
        0x91238eda9e1788a8,
    };
    public static readonly ulong[] Rook14 = // 14-bit magics. Works for blockerMask * magic >> 50
    {
        0x24baf7a2c5fc9e00,
        0x5a00039f3f1b9600,
        0x8600013e21519a00,
        0x8dfffeefd8efa360,
        0xc60003b1011e7a00,
        0x35ffffcbd206e978,
        0xd400079117fa2314,
        0x7c29b5fa56cf1eb2,
        0x653e9ab754b83500,
        0x83fffe1b7f0e4380,
        0x45ae000125cc1740,
        0xb50a0000b799eb60,
        0x9ea1fffe71342ad0,
        0xf8a407ff9a1ca3f8,
        0x26ebfffd4020bd08,
        0x8630dac1287d55dc,
        0xffffef3f97924a00,
        0x5890b20002ae5880,
        0x68bc9f0002576f00,
        0x2a2df20df2d02e20,
        0xa58b510001799300,
        0x94b6fa0000268e4e,
        0xd8c8340001d0ba18,
        0x79b4e6e938483430,
        0x372c54fde387e00,
        0xa9cfad8f708fe200,
        0xecba4b21d1757700,
        0xee302cd1ffff6760,
        0xd8f347be00009610,
        0x483479260001a8a8,
        0x66fb9fee0000232c,
        0xc48cd13ecd8f47ee,
        0x66e9a5d520555500,
        0x8e7d50dfbe000600,
        0xebb3e6b0adfffef2,
        0x6072ca482000160,
        0xc297c08efdfffcb0,
        0xcfad25abfc03fb58,
        0x7bcc9ddf3bffff28,
        0xd3b08b7a1d9c51bc,
        0x2978d55c4d5c2400,
        0xe063bfab4c3f3880,
        0x23002c2910325000,
        0xba22f01990165000,
        0xe35fe76511061c00,
        0x46bc7ea140b7fff0,
        0x4104ee3381de0004,
        0xcd0913e3eda79d9e,
        0x654662f66fd85200,
        0xea4c83a8c4816600,
        0xd6c899ee86bf4600,
        0x39697a95538a1600,
        0xef33e672f5f43200,
        0xf1c70e94d3e65e00,
        0x9ba116cf18f58400,
        0xa5839115ee9cadc0,
        0xb17ed83153e7f5fe,
        0x3a6b5a0023ae6cb2,
        0x1fff65de62aacea,
        0xcc170a002b0c872a,
        0x1a8efcd6001e0486,
        0x9eb2795803fd32fa,
        0x7268432800b9df5c,
        0x46c1b625950080ae
    };
}