using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Nato
{
    public class Utils
    {
        public static void LoadMenu()
        {
            Utils.PrimaryColorTextLine(Art.NATO);
            Utils.PrimaryColorTextLine("Current Fortnite Version - " + File.ReadAllText("FortniteVersion.txt"));
            Console.WriteLine();
            Utils.PrimaryColorTextLine("[1] Pickaxes");
            Utils.PrimaryColorTextLine("[2] Gliders");
            Utils.PrimaryColorTextLine("[3] Settings");
            Utils.PrimaryColorTextLine("[4] Exit");
            Console.WriteLine();
            Utils.PrimaryColorTextLine("[5] Twitter || @nax1800");
            Utils.PrimaryColorTextLine("[6] Discord || discord.gg/Ms58rcs4KV");
            Console.WriteLine();
            Utils.SecondaryColorText("Where Would You Like To Go: ");
        }

        public static void LoadOptionMainMenu()
        {
            switch (Console.ReadLine())
            {
                case "1":
                    LoadOptionPickaxes();
                    break;


                case "2":
                    LoadOptionGliders();
                    break;

                case "3":
                    LoadSettings();
                    break;

                case "4":
                    Process.GetCurrentProcess().Kill();
                    break;

                case "5":
                    OpenUrl("https://twitter.com/@nax1800");
                    Program.Main();
                    break;

                case "6":
                    OpenUrl("https://discord.gg/Ms58rcs4KV");
                    Program.Main();
                    break;

                case "":
                    Program.Main();
                    break;
            }
        }

        public static void OpenUrl(string url)
        {
            try
            {
                Process.Start(url);
            }
            catch
            {
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
        }

        public static void Unavailable()
        {
            PrimaryColorTextLine("Currently Unavailable.");
            Thread.Sleep(500);
            Program.Main();
        }

        public static void PrimaryColorText(string text)
        {
            string color = File.ReadAllText("PrimaryColor.txt");

            if(color.ToLower() == "blue"){ BlueText(text); }
            if (color.ToLower() == "red") { RedText(text); }
            if (color.ToLower() == "magenta") { MagentaText(text); }
            if (color.ToLower() == "cyan") { CyanText(text); }
            if (color.ToLower() == "darkcyan") { DarkCyanText(text); }
            if (color.ToLower() == "yellow") { YellowText(text); }
            if (color.ToLower() == "darkblue") { DarkBlueText(text); }
            if (color.ToLower() == "magenta") { DarkGrayText(text); }
            if (color.ToLower() == "darkgray") { DarkCyanTextLine(text); }
            if (color.ToLower() == "darkgreen") { DarkGreenText(text); }
            if (color.ToLower() == "green") { GreenText(text); }
            if (color.ToLower() == "white") { WhiteText(text); }
            if (color.ToLower() == "darkred") { DarkRedText(text); }
            if (color.ToLower() == "darkyellow") { DarkYellowText(text); }
        }

        public static void PrimaryColorTextLine(string text)
        {
            string color = File.ReadAllText("PrimaryColor.txt");

            if (color.ToLower() == "blue") { BlueTextLine(text); }
            if (color.ToLower() == "red") { RedTextLine(text); }
            if (color.ToLower() == "magenta") { MagentaTextLine(text); }
            if (color.ToLower() == "cyan") { CyanTextLine(text); }
            if (color.ToLower() == "darkcyan") { DarkCyanTextLine(text); }
            if (color.ToLower() == "yellow") { YellowTextLine(text); }
            if (color.ToLower() == "darkblue") { DarkBlueTextLine(text); }
            if (color.ToLower() == "magenta") { DarkGrayTextLine(text); }
            if (color.ToLower() == "darkgray") { SecondaryColorTextLine(text); }
            if (color.ToLower() == "darkgreen") { DarkGreenTextLine(text); }
            if (color.ToLower() == "green") { GreenTextLine(text); }
            if (color.ToLower() == "white") { WhiteTextLine(text); }
            if (color.ToLower() == "darkred") { DarkRedTextLine(text); }
            if (color.ToLower() == "darkyellow") { DarkYellowTextLine(text); }
        }
        public static void SecondaryColorText(string text)
        {
            string color = File.ReadAllText("SecondaryColor.txt");

            if (color.ToLower() == "blue") { BlueText(text); }
            if (color.ToLower() == "red") { RedText(text); }
            if (color.ToLower() == "magenta") { MagentaText(text); }
            if (color.ToLower() == "cyan") { CyanText(text); }
            if (color.ToLower() == "yellow") { YellowText(text); }
            if (color.ToLower() == "darkblue") { DarkBlueText(text); }
            if (color.ToLower() == "magenta") { DarkGrayText(text); }
            if (color.ToLower() == "darkgray") { DarkCyanText(text); }
            if (color.ToLower() == "darkgreen") { DarkGreenText(text); }
            if (color.ToLower() == "green") { GreenText(text); }
            if (color.ToLower() == "white") { WhiteText(text); }
            if (color.ToLower() == "darkred") { DarkRedText(text); }
            if (color.ToLower() == "darkyellow") { DarkYellowText(text); }
        }

        public static void SecondaryColorTextLine(string text)
        {
            string color = File.ReadAllText("SecondaryColor.txt");

            if (color.ToLower() == "blue") { BlueTextLine(text); }
            if (color.ToLower() == "red") { RedTextLine(text); }
            if (color.ToLower() == "magenta") { MagentaTextLine(text); }
            if (color.ToLower() == "cyan") { CyanTextLine(text); }
            if (color.ToLower() == "yellow") { YellowTextLine(text); }
            if (color.ToLower() == "darkblue") { DarkBlueTextLine(text); }
            if (color.ToLower() == "magenta") { DarkGrayTextLine(text); }
            if (color.ToLower() == "darkgray") { DarkCyanTextLine(text); }
            if (color.ToLower() == "darkgreen") { DarkGreenTextLine(text); }
            if (color.ToLower() == "green") { GreenTextLine(text); }
            if (color.ToLower() == "white") { WhiteTextLine(text); }
            if (color.ToLower() == "darkred") { DarkRedTextLine(text); }
            if (color.ToLower() == "darkyellow") { DarkYellowTextLine(text); }
        }


        public static void ChangeColor(string color, bool primary)
        {
            string file = null;
            if (primary)
                file = "PrimaryColor.txt";
            if (!primary)
                file = "SecondaryColor.txt";
            switch (color)
            {
                case "1":
                    File.WriteAllText(file, "blue");
                    break;

                case "2":
                    File.WriteAllText(file, "red");
                    break;

                case "3":
                    File.WriteAllText(file, "magenta");
                    break;

                case "4":
                    File.WriteAllText(file, "yellow");
                    break;

                case "5":
                    File.WriteAllText(file, "cyan");
                    break;

                case "6":
                    File.WriteAllText(file, "green");
                    break;

                case "7":
                    File.WriteAllText(file, "darkblue");
                    break;

                case "8":
                    File.WriteAllText(file, "DarkYellow");
                    break;

                case "9":
                    File.WriteAllText(file, "DarkCyan");
                    break;

                case "10":
                    File.WriteAllText(file, "DarkGreen");
                    break;

                case "11":
                    File.WriteAllText(file, "DarkGray");
                    break;

                case "12":
                    File.WriteAllText(file, "DarkRed");
                    break;

            }
        }

        public static void ColorChoices()
        {
            Console.Clear();
            PrimaryColorTextLine("What Color Would You Like To Use For Your Primary Color?");
            Console.WriteLine();
            PrimaryColorTextLine("[1] Blue");
            PrimaryColorTextLine("[2] Red");
            PrimaryColorTextLine("[3] Magenta");
            PrimaryColorTextLine("[4] Yellow");
            PrimaryColorTextLine("[5] Cyan");
            PrimaryColorTextLine("[6] Green");
            PrimaryColorTextLine("[7] Dark Blue");
            PrimaryColorTextLine("[8] Dark Yellow");
            PrimaryColorTextLine("[9] Dark Cyan");
            PrimaryColorTextLine("[10] Dark Green");
            PrimaryColorTextLine("[11] Dark Gray");
            PrimaryColorTextLine("[12] Dark Red");
            string pcolor = Console.ReadLine();
            var task = Task.Run(() =>
            {
                ChangeColor(pcolor, true);
            });
                        task.Wait();
            Console.Clear();
            PrimaryColorTextLine("What Color Would You Like To Use For Your Secondary Color?");
            Console.WriteLine();
            PrimaryColorTextLine("[1] Blue");
            PrimaryColorTextLine("[2] Red");
            PrimaryColorTextLine("[3] Magenta");
            PrimaryColorTextLine("[4] Yellow");
            PrimaryColorTextLine("[5] Cyan");
            PrimaryColorTextLine("[6] Green");
            PrimaryColorTextLine("[7] Dark Blue");
            PrimaryColorTextLine("[8] Dark Yellow");
            PrimaryColorTextLine("[9] Dark Cyan");
            PrimaryColorTextLine("[10] Dark Green");
            PrimaryColorTextLine("[11] Dark Gray");
            PrimaryColorTextLine("[12] Dark Red");
            string scolor = Console.ReadLine();
            ChangeColor(scolor, false);
            Program.Main();
        }

        public static void LoadOptionPickaxes()
        {
            switch (File.ReadAllText("FortniteVersion.txt"))
            {
                case "1.7.2":
                    Unreal_Engine_416.LoadPickaxes();
                    break;

                case "1.8":
                    Unreal_Engine_416.LoadPickaxes();
                    break;

                case "1.8.1":
                    Unreal_Engine_416.LoadPickaxes();
                    break;

                case "1.8.2":
                    Unreal_Engine_416.LoadPickaxes();
                    break;

                case "1.9":
                    Unreal_Engine_416.LoadPickaxes();
                    break;

                case "1.9.1":
                    Unreal_Engine_416.LoadPickaxes();
                    break;

                case "1.10":
                    break;

                case "1.11":
                    Unreal_Engine_419.LoadPickaxes();
                    break;

                case "3.5":
                    Unreal_Engine_420.LoadPickaxes();
                    break;

                case "4.1":
                    Unreal_Engine_420.LoadPickaxes();
                    break;

                case "5.41":
                    Unreal_Engine_420.LoadPickaxes();
                    break;

                case "7.0":
                    Unreal_Engine_422.LoadPickaxes();
                    break;

                case "7.1":
                    Unreal_Engine_422.LoadPickaxes();
                    break;

                case "7.2":
                    Unreal_Engine_422.LoadPickaxes();
                    break;

                case "7.3":
                    Unreal_Engine_422.LoadPickaxes();
                    break;

                case "7.4":
                    Unreal_Engine_422.LoadPickaxes();
                    break;

                case "9.1":
                    Unreal_Engine_423.LoadPickaxes();
                    break;

                case "":
                    LoadOptionPickaxes();
                    break;
            }
        }

        public static void LoadOptionGliders()
        {
            switch (File.ReadAllText("FortniteVersion.txt"))
            {
                case "1.7.2":
                    Unavailable();
                    break;

                case "1.8":
                    Unavailable();
                    break;

                case "1.8.1":
                    Unavailable();
                    break;

                case "1.8.2":
                    Unavailable();
                    break;

                case "1.9":
                    Unavailable();
                    break;

                case "1.9.1":
                    Unavailable();
                    break;

                case "1.10":
                    Unavailable();
                    break;

                case "1.11":
                    Unavailable();
                    break;

                case "4.1":
                    Unreal_Engine_419.LoadGliders();
                    break;

                case "7.0":
                    Unreal_Engine_422.MenuChoiceGlider();
                    break;

                case "7.1":
                    Unreal_Engine_422.MenuChoiceGlider();
                    break;

                case "7.2":
                    Unreal_Engine_422.MenuChoiceGlider();
                    break;

                case "7.3":
                    Unreal_Engine_422.MenuChoiceGlider();
                    break;

                case "7.4":
                    Unreal_Engine_422.MenuChoiceGlider();
                    break;

                case "9.1":
                    break;

                case "":
                    LoadOptionGliders();
                    break;
            }
        }

        public static void ChangePath()
        {
            Console.Clear();
            SecondaryColorText("Paste Your Paks Path Here > ");
            string pakspath = Console.ReadLine();
            File.WriteAllText("PaksPath.txt", pakspath + @"\");
            Console.WriteLine();
            ChangeVersion();
        }

        public static void ChangeVersion()
        {
            SecondaryColorTextLine("If You Want To See All Versions Available, Do '/versions' ");
            SecondaryColorText("Put Your Fortnite Version Here > ");
            string fnver = Console.ReadLine();
            if (fnver.ToLower() == "/versions")
            {
                Console.WriteLine();
                SecondaryColorTextLine("1.7.2");
                SecondaryColorTextLine("1.8");
                SecondaryColorTextLine("1.8.1");
                SecondaryColorTextLine("1.8.2");
                SecondaryColorTextLine("1.9");
                SecondaryColorTextLine("1.9.1");
                SecondaryColorTextLine("1.10");
                SecondaryColorTextLine("1.11");
                SecondaryColorTextLine("3.5");
                SecondaryColorTextLine("4.1");
                SecondaryColorTextLine("5.41");
                SecondaryColorTextLine("7.0");
                SecondaryColorTextLine("7.1");
                SecondaryColorTextLine("7.2");
                SecondaryColorTextLine("7.3");
                SecondaryColorTextLine("7.4");
                SecondaryColorTextLine("9.1");
                Console.WriteLine();
                ChangeVersion();
            }
            else
            {
                File.WriteAllText("FortniteVersion.txt", fnver);
                Console.ReadLine();
                Program.Main();
            }
        }

        public static void SeePath()
        {
            Console.Clear();
            PrimaryColorTextLine($"Current Paks Path > {File.ReadAllText("PaksPath.txt")}");
            PrimaryColorTextLine($"Current Fortnite Version > {File.ReadAllText("FortniteVersion.txt")}");
            Console.ReadLine();
            Program.Main();
        }

        public static void LoadSettings()
        {
            Console.Clear();
            PrimaryColorTextLine(Art.setting);
            SecondaryColorTextLine("[1] Change Paks Path & FN Version");
            SecondaryColorTextLine("[2] See Paks Path & FN Version");
            SecondaryColorTextLine("[3] Change Colours");
            SecondaryColorTextLine("[4] Back");
            SecondaryColorText("Where Would You Like To Go? :");
            LoadOptionSettings();
        }

        public static void LoadOptionSettings()
        {
            switch (Console.ReadLine())
            {
                case "1":
                    ChangePath();
                    break;

                case "2":
                    SeePath();
                    break;

                case "3":
                    ColorChoices();
                    break;

                case "4":
                    Program.Main();
                    break;

                case "":
                    LoadOptionSettings();
                    break;
            }
        }


        public static void Download(string link, string name, bool pak)
        {
            var task = Task.Run(() =>
            {
                new WebClient().DownloadFile(link, File.ReadAllText("PaksPath.txt") + name);
                Console.Title = "Downloading File...";
            });
            task.Wait();
                Completed(pak);
        }

       public static void Completed(bool pak)
        {
            if(pak)
            GreenTextLine($"Successfully Downloaded Pak!");
            Console.Title = "Downloaded Pak!";

            if (!pak)
                GreenTextLine($"Successfully Downloaded Sig!");
                Console.Title = "Downloaded Sig!";
        }

        public static void YellowTextLine(string text)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(text);
        }

        public static void YellowText(string text)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(text);
        }

        public static void RedTextLine(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
        }

        public static void RedText(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(text);
        }

        public static void GreenTextLine(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(text);
        }

        public static void GreenText(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(text);
        }

        public static void BlueTextLine(string text)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(text);
        }

        public static void BlueText(string text)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(text);
        }

        public static void CyanTextLine(string text)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(text);
        }

        public static void CyanText(string text)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(text);
        }

        public static void MagentaTextLine(string text)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(text);
        }

        public static void MagentaText(string text)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(text);
        }

        public static void WhiteTextLine(string text)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(text);
        }

        public static void WhiteText(string text)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(text);
        }

        public static void DarkBlueTextLine(string text)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(text);
        }

        public static void DarkBlueText(string text)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write(text);
        }

        public static void DarkCyanTextLine(string text)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(text);
        }

        public static void DarkCyanText(string text)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(text);
        }
        public static void DarkGreenTextLine(string text)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(text);
        }

        public static void DarkGreenText(string text)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(text);
        }

        public static void DoFilesExist()
        {
            bool opensettings = false;
            if (!File.Exists("PaksPath.txt"))
            {
                File.Create("PaksPath.txt").Close();
                opensettings = true;
            }
            if (!File.Exists("FortniteVersion.txt"))
            {
                File.Create("FortniteVersion.txt").Close();
                opensettings = true;
            }
            if (!File.Exists("SecondaryColor.txt"))
            {
                File.Create("SecondaryColor.txt").Close();
                File.WriteAllText("SecondaryColor.txt", "cyan");
                opensettings = true;
            }
            if (!File.Exists("PrimaryColor.txt"))
            {
                File.Create("PrimaryColor.txt").Close();
                File.WriteAllText("PrimaryColor.txt", "darkcyan");
                opensettings = true;
            }
            Console.Clear();
            if (!opensettings)
            {
                Utils.LoadMenu();
                Utils.LoadOptionMainMenu();
            }
            else
            {
                Utils.RedTextLine("PLEASE SELECT YOUR PAKS PATH AND FORTNITE VERSION.");
                Thread.Sleep(1500);
                Utils.LoadSettings();
            }
        }
        public static void GrayTextLine(string text)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(text);
        }

        public static void GrayText(string text)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(text);
        }

        public static void DarkGrayTextLine(string text)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(text);
        }

        public static void DarkGrayText(string text)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(text);
        }

        public static void DarkMagentaTextLine(string text)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(text);
        }

        public static void DarkMagentaText(string text)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(text);
        }

        public static void DarkRedTextLine(string text)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(text);
        }

        public static void DarkRedText(string text)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(text);
        }

        public static void DarkYellowTextLine(string text)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(text);
        }

        public static void DarkYellowText(string text)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(text);
        }
    }
}
