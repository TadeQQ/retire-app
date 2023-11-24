using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        for (int A = 1; A < 10; A++)
        {
            for (int B = 0; B < 10; B++)
            {
                if (B == A) continue;
                for (int C = 0; C < 10; C++)
                {
                    if (C == A || C == B) continue;
                    for (int D = 0; D < 10; D++)
                    {
                        if (D == A || D == B || D == C) continue;
                        for (int E = 0; E < 10; E++)
                        {
                            if (E == A || E == B || E == C || E == D) continue;
                            for (int F = 1; F < 10; F++)
                            {
                                if (F == A || F == B || F == C || F == D || F == E) continue;
                                for (int G = 0; G < 10; G++)
                                {
                                    if (G == A || G == B || G == C || G == D || G == E || G == F) continue;
                                    for (int H = 0; H < 10; H++)
                                    {
                                        if (H == A || H == B || H == C || H == D || H == E || H == F || H == G) continue;
                                        int num1 = 10000 * A + 1000 * B + 100 * C + 10 * D + E;
                                        int num2 = 100 * F + 10 * G + A;
                                        int result = num1 * num2;
                                        if (result == 1000000 * F + 100000 * D + 10000 * E + 1000 * D + 100 * H + 10 * H + H)
                                        {
                                            Console.WriteLine($"A={A}, B={B}, C={C}, D={D}, E={E}, F={F}, G={G}, H={H}");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
