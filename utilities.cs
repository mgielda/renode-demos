/*
 * Copyright (c) 2021 Antmicro
 *
 * SPDX-License-Identifier: Apache-2.0
 */

namespace RenodeDemos
{
    public static class DemosHelper
    {
        public static async Task ProgressChar(int delay = 50, int iterations = 10)
        {
            char[] chars = {'|','/','-','\\'};
            for (int i = 0; i < iterations; i++)
            {
                foreach (char c in chars) {
                    Console.Write(c);
                    await Task.Delay(delay);
                    Console.Write("\b");
                }
            }
            Console.WriteLine();
        }
    }
}
