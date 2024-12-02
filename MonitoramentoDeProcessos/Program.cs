using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace MonitoramentoDeProcessos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> processosConfiaveis = new List<string>
            {
                "explorer.exe", "python.exe", "chrome.exe", "firefox.exe", "vscode.exe"
            };

            // Monitoramento contínuo de processos
            while (true)
            {
                VerificarProcessosSuspeitos(processosConfiaveis);
                Thread.Sleep(10000); // Verifica a cada 10 segundos
            }
        }

        static void VerificarProcessosSuspeitos(List<string> processosConfiaveis)
        {
            Process[] processos = Process.GetProcesses();
            bool encontrouSuspeitos = false;

            foreach (Process processo in processos)
            {
                try
                {
                    string nomeProcesso = processo.ProcessName.ToLower();

                    if (!processosConfiaveis.Exists(p => p.ToLower() == nomeProcesso))
                    {
                        Console.WriteLine($"Processo suspeito encontrado: {nomeProcesso} (PID: {processo.Id})");
                        encontrouSuspeitos = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao acessar o processo: {ex.Message}");
                }
            }

            if (!encontrouSuspeitos)
            {
                Console.WriteLine("Nenhum processo suspeito encontrado.");
            }
        }
    }
}
