/*
 * Copyright (c) 2021 Antmicro
 *
 * SPDX-License-Identifier: Apache-2.0
 */

using RenodeDemos;

for(int i = 0; i < args.Length; i++)
{
    Console.WriteLine($"{i}: {args[i]}");
}

await DemosHelper.ProgressChar(50, 10);

Console.WriteLine("Done.");
