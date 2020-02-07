using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copy_Writer
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] allStations = { @"E:\WeatherLink\Hisar\Download.txt", @"E:\WeatherLink\Svilengr\Download.txt",
            @"E:\WeatherLink\Chehljov\Download.txt", @"E:\WeatherLink\Chirpan\Download.TXT", @"E:\WeatherLink\Devin\Download.TXT",
            @"E:\WeatherLink\Velingra\Download.TXT", @"E:\WeatherLink\Smoljan\Download.txt", @"E:\WeatherLink\Zlatogra\Download.txt",
            @"E:\WeatherLink\Lubimets\Download.txt", @"E:\WeatherLink\Koprivsh\Download.txt",
            @"E:\WeatherLink\Zlatitsa\Download.TXT", @"E:\WeatherLink\Karlovo\Download.txt",
            @"E:\WeatherLink\Barutin\Download.txt" };

            string[] allFilesExists = { @"\\195.96.246.33\automatic\DOWNHISA.TXT", @"\\195.96.246.33\automatic\14_08_2008\DOWNHISA.TXT",
            @"\\195.96.246.33\automatic\DOWNSVIL.TXT", @"\\195.96.246.33\automatic\14_08_2008\DOWNSVIL.TXT",
            @"\\195.96.246.33\automatic\DOWNCHEH.TXT", @"\\195.96.246.33\automatic\14_08_2008\DOWNCHEH.TXT",
            @"\\195.96.246.33\automatic\DOWNCHRP.TXT", @"\\195.96.246.33\automatic\14_08_2008\DOWNCHRP.TXT",
            @"\\195.96.246.33\automatic\DOWNDEVN.TXT", @"\\195.96.246.33\automatic\14_08_2008\DOWNDEVN.TXT",
            @"\\195.96.246.33\automatic\DOWNVELI.TXT", @"\\195.96.246.33\automatic\14_08_2008\DOWNVELI.TXT",
            @"\\195.96.246.33\automatic\DOWNSMOL.TXT", @"\\195.96.246.33\automatic\14_08_2008\DOWNSMOL.TXT",
            @"\\195.96.246.33\automatic\DOWNZLAT.TXT", @"\\195.96.246.33\automatic\14_08_2008\DOWNZLAT.TXT",
            @"\\195.96.246.33\automatic\DOWNLUBI.TXT", @"\\195.96.246.33\automatic\14_08_2008\DOWNLUBI.TXT",
            @"\\195.96.246.33\automatic\DOWNKOPR.TXT", @"\\195.96.246.33\automatic\14_08_2008\DOWNKOPR.TXT",
            @"\\195.96.246.33\automatic\DOWNZLAC.TXT", @"\\195.96.246.33\automatic\14_08_2008\DOWNZLAC.TXT",
            @"\\195.96.246.33\automatic\DOWNKARL.TXT", @"\\195.96.246.33\automatic\14_08_2008\DOWNKARL.TXT",
            @"\\195.96.246.33\automatic\DOWNBARU.TXT", @"\\195.96.246.33\automatic\14_08_2008\DOWNBARU.TXT" };

            for (int i = 0; i <= allStations.Length; i++)
            {
                if (File.Exists(@"\\195.96.246.33\automatic\DOWNBARU.TXT"))
                    File.Delete(@"\\195.96.246.33\automatic\DOWNBARU.TXT");

                if (File.Exists(@"\\195.96.246.33\automatic\14_08_2008\DOWNBARU.TXT"))
                    File.Delete(@"\\195.96.246.33\automatic\14_08_2008\DOWNBARU.TXT");

                if (File.Exists(@"\\195.96.246.33\automatic\DOWNDEVN.TXT"))
                    File.Delete(@"\\195.96.246.33\automatic\DOWNDEVN.TXT");

                if (File.Exists(@"\\195.96.246.33\automatic\14_08_2008\DOWNDEVN.TXT"))
                    File.Delete(@"\\195.96.246.33\automatic\14_08_2008\DOWNDEVN.TXT");

                if (File.Exists(@"\\195.96.246.33\automatic\DOWNCHRP.TXT"))
                    File.Delete(@"\\195.96.246.33\automatic\DOWNCHRP.TXT");

                if (File.Exists(@"\\195.96.246.33\automatic\14_08_2008\DOWNCHRP.TXT"))
                    File.Delete(@"\\195.96.246.33\automatic\14_08_2008\DOWNCHRP.TXT");

                if (File.Exists(@"\\195.96.246.33\automatic\DOWNHISA.TXT"))
                    File.Delete(@"\\195.96.246.33\automatic\DOWNHISA.TXT");

                if (File.Exists(@"\\195.96.246.33\automatic\14_08_2008\DOWNHISA.TXT"))
                    File.Delete(@"\\195.96.246.33\automatic\14_08_2008\DOWNHISA.TXT");

                if (File.Exists(@"\\195.96.246.33\automatic\DOWNSVIL.TXT"))
                    File.Delete(@"\\195.96.246.33\automatic\DOWNSVIL.TXT");

                if (File.Exists(@"\\195.96.246.33\automatic\14_08_2008\DOWNSVIL.TXT"))
                    File.Delete(@"\\195.96.246.33\automatic\14_08_2008\DOWNSVIL.TXT");

                if (File.Exists(@"\\195.96.246.33\automatic\DOWNCHEH.TXT"))
                    File.Delete(@"\\195.96.246.33\automatic\DOWNCHEH.TXT");

                if (File.Exists(@"\\195.96.246.33\automatic\14_08_2008\DOWNCHEH.TXT"))
                    File.Delete(@"\\195.96.246.33\automatic\14_08_2008\DOWNCHEH.TXT");

                if (File.Exists(@"\\195.96.246.33\automatic\DOWNVELI.TXT"))
                    File.Delete(@"\\195.96.246.33\automatic\DOWNVELI.TXT");

                if (File.Exists(@"\\195.96.246.33\automatic\14_08_2008\DOWNVELI.TXT"))
                    File.Delete(@"\\195.96.246.33\automatic\14_08_2008\DOWNVELI.TXT");

                if (File.Exists(@"\\195.96.246.33\automatic\DOWNSMOL.TXT"))
                    File.Delete(@"\\195.96.246.33\automatic\DOWNSMOL.TXT");

                if (File.Exists(@"\\195.96.246.33\automatic\14_08_2008\DOWNSMOL.TXT"))
                    File.Delete(@"\\195.96.246.33\automatic\14_08_2008\DOWNSMOL.TXT");

                if (File.Exists(@"\\195.96.246.33\automatic\DOWNZLAT.TXT"))
                    File.Delete(@"\\195.96.246.33\automatic\DOWNZLAT.TXT");

                if (File.Exists(@"\\195.96.246.33\automatic\14_08_2008\DOWNZLAT.TXT"))
                    File.Delete(@"\\195.96.246.33\automatic\14_08_2008\DOWNZLAT.TXT");

                if (File.Exists(@"\\195.96.246.33\automatic\DOWNLUBI.TXT"))
                    File.Delete(@"\\195.96.246.33\automatic\DOWNLUBI.TXT");

                if (File.Exists(@"\\195.96.246.33\automatic\14_08_2008\DOWNLUBI.TXT"))
                    File.Delete(@"\\195.96.246.33\automatic\14_08_2008\DOWNLUBI.TXT");

                if (File.Exists(@"\\195.96.246.33\automatic\DOWNKOPR.TXT"))
                    File.Delete(@"\\195.96.246.33\automatic\DOWNKOPR.TXT");

                if (File.Exists(@"\\195.96.246.33\automatic\14_08_2008\DOWNKOPR.TXT"))
                    File.Delete(@"\\195.96.246.33\automatic\14_08_2008\DOWNKOPR.TXT");

                if (File.Exists(@"\\195.96.246.33\automatic\DOWNZLAC.TXT"))
                    File.Delete(@"\\195.96.246.33\automatic\DOWNZLAC.TXT");

                if (File.Exists(@"\\195.96.246.33\automatic\14_08_2008\DOWNZLAC.TXT"))
                    File.Delete(@"\\195.96.246.33\automatic\14_08_2008\DOWNZLAC.TXT");

                if (File.Exists(@"\\195.96.246.33\automatic\DOWNKARL.TXT"))
                    File.Delete(@"\\195.96.246.33\automatic\DOWNKARL.TXT");

                if (File.Exists(@"\\195.96.246.33\automatic\14_08_2008\DOWNKARL.TXT"))
                    File.Delete(@"\\195.96.246.33\automatic\14_08_2008\DOWNKARL.TXT");

                System.IO.File.Copy(@"E:\WeatherLink\Barutin\Download.txt", @"\\195.96.246.33\automatic\DOWNBARU.TXT");

                System.IO.File.Copy(@"E:\WeatherLink\Barutin\Download.txt", @"\\195.96.246.33\automatic\14_08_2008\DOWNBARU.TXT");

                System.IO.File.Copy(@"E:\WeatherLink\Hisar\Download.txt", @"\\195.96.246.33\automatic\DOWNHISA.TXT");

                System.IO.File.Copy(@"E:\WeatherLink\Hisar\Download.txt", @"\\195.96.246.33\automatic\14_08_2008\DOWNHISA.TXT");

                System.IO.File.Copy(@"E:\WeatherLink\Svilengr\Download.txt", @"\\195.96.246.33\automatic\DOWNSVIL.TXT");

                System.IO.File.Copy(@"E:\WeatherLink\Svilengr\Download.txt", @"\\195.96.246.33\automatic\14_08_2008\DOWNSVIL.TXT");

                System.IO.File.Copy(@"E:\WeatherLink\Chehljov\Download.txt", @"\\195.96.246.33\automatic\DOWNCHEH.TXT");

                System.IO.File.Copy(@"E:\WeatherLink\Chehljov\Download.txt", @"\\195.96.246.33\automatic\14_08_2008\DOWNCHEH.TXT");

                System.IO.File.Copy(@"E:\WeatherLink\Chirpan\Download.TXT", @"\\195.96.246.33\automatic\DOWNCHRP.TXT");

                System.IO.File.Copy(@"E:\WeatherLink\Chirpan\Download.TXT", @"\\195.96.246.33\automatic\14_08_2008\DOWNCHRP.TXT");

                System.IO.File.Copy(@"E:\WeatherLink\Devin\Download.TXT", @"\\195.96.246.33\automatic\DOWNDEVN.TXT");

                System.IO.File.Copy(@"E:\WeatherLink\Devin\Download.TXT", @"\\195.96.246.33\automatic\14_08_2008\DOWNDEVN.TXT");

                System.IO.File.Copy(@"E:\WeatherLink\Velingra\Download.TXT", @"\\195.96.246.33\automatic\DOWNVELI.TXT");

                System.IO.File.Copy(@"E:\WeatherLink\Velingra\Download.TXT", @"\\195.96.246.33\automatic\14_08_2008\DOWNVELI.TXT");

                System.IO.File.Copy(@"E:\WeatherLink\Smoljan\Download.txt", @"\\195.96.246.33\automatic\DOWNSMOL.TXT");

                System.IO.File.Copy(@"E:\WeatherLink\Smoljan\Download.txt", @"\\195.96.246.33\automatic\14_08_2008\DOWNSMOL.TXT");

                System.IO.File.Copy(@"E:\WeatherLink\Zlatogra\Download.txt", @"\\195.96.246.33\automatic\DOWNZLAT.TXT");

                System.IO.File.Copy(@"E:\WeatherLink\Zlatogra\Download.txt", @"\\195.96.246.33\automatic\14_08_2008\DOWNZLAT.TXT");

                System.IO.File.Copy(@"E:\WeatherLink\Lubimets\Download.txt", @"\\195.96.246.33\automatic\DOWNLUBI.TXT");

                System.IO.File.Copy(@"E:\WeatherLink\Lubimets\Download.txt", @"\\195.96.246.33\automatic\14_08_2008\DOWNLUBI.TXT");

                System.IO.File.Copy(@"E:\WeatherLink\Koprivsh\Download.txt", @"\\195.96.246.33\automatic\DOWNKOPR.TXT");

                System.IO.File.Copy(@"E:\WeatherLink\Koprivsh\Download.txt", @"\\195.96.246.33\automatic\14_08_2008\DOWNKOPR.TXT");

                System.IO.File.Copy(@"E:\WeatherLink\Zlatitsa\Download.TXT", @"\\195.96.246.33\automatic\DOWNZLAC.TXT");

                System.IO.File.Copy(@"E:\WeatherLink\Zlatitsa\Download.TXT", @"\\195.96.246.33\automatic\14_08_2008\DOWNZLAC.TXT");

                System.IO.File.Copy(@"E:\WeatherLink\Karlovo\Download.txt", @"\\195.96.246.33\automatic\DOWNKARL.TXT");

                System.IO.File.Copy(@"E:\WeatherLink\Karlovo\Download.txt", @"\\195.96.246.33\automatic\14_08_2008\DOWNKARL.TXT");

                File.AppendAllText(@"\\195.96.246.33\automatic\DOWNBARU.TXT",
                    Environment.NewLine);

                File.AppendAllText(@"\\195.96.246.33\automatic\14_08_2008\DOWNBARU.TXT",
                    Environment.NewLine);

                File.AppendAllText(@"\\195.96.246.33\automatic\DOWNHISA.TXT",
                    Environment.NewLine);

                File.AppendAllText(@"\\195.96.246.33\automatic\14_08_2008\DOWNHISA.TXT",
                    Environment.NewLine);

                File.AppendAllText(@"\\195.96.246.33\automatic\DOWNSVIL.TXT",
                    Environment.NewLine);

                File.AppendAllText(@"\\195.96.246.33\automatic\14_08_2008\DOWNSVIL.TXT",
                    Environment.NewLine);

                File.AppendAllText(@"\\195.96.246.33\automatic\DOWNCHEH.TXT",
                    Environment.NewLine);

                File.AppendAllText(@"\\195.96.246.33\automatic\14_08_2008\DOWNCHEH.TXT",
                    Environment.NewLine);

                File.AppendAllText(@"\\195.96.246.33\automatic\DOWNCHRP.TXT",
                    Environment.NewLine);

                File.AppendAllText(@"\\195.96.246.33\automatic\14_08_2008\DOWNCHRP.TXT",
                    Environment.NewLine);

                File.AppendAllText(@"\\195.96.246.33\automatic\DOWNDEVN.TXT",
                    Environment.NewLine);

                File.AppendAllText(@"\\195.96.246.33\automatic\14_08_2008\DOWNDEVN.TXT",
                    Environment.NewLine);

                File.AppendAllText(@"\\195.96.246.33\automatic\DOWNVELI.TXT",
                    Environment.NewLine);

                File.AppendAllText(@"\\195.96.246.33\automatic\14_08_2008\DOWNVELI.TXT",
                    Environment.NewLine);

                File.AppendAllText(@"\\195.96.246.33\automatic\DOWNSMOL.TXT",
                    Environment.NewLine);

                File.AppendAllText(@"\\195.96.246.33\automatic\14_08_2008\DOWNSMOL.TXT",
                    Environment.NewLine);

                File.AppendAllText(@"\\195.96.246.33\automatic\DOWNZLAT.TXT",
                    Environment.NewLine);

                File.AppendAllText(@"\\195.96.246.33\automatic\14_08_2008\DOWNZLAT.TXT",
                    Environment.NewLine);

                File.AppendAllText(@"\\195.96.246.33\automatic\DOWNLUBI.TXT",
                    Environment.NewLine);

                File.AppendAllText(@"\\195.96.246.33\automatic\14_08_2008\DOWNLUBI.TXT",
                    Environment.NewLine);

                File.AppendAllText(@"\\195.96.246.33\automatic\DOWNKOPR.TXT",
                    Environment.NewLine);

                File.AppendAllText(@"\\195.96.246.33\automatic\14_08_2008\DOWNKOPR.TXT",
                    Environment.NewLine);

                File.AppendAllText(@"\\195.96.246.33\automatic\DOWNZLAC.TXT",
                    Environment.NewLine);

                File.AppendAllText(@"\\195.96.246.33\automatic\14_08_2008\DOWNZLAC.TXT",
                    Environment.NewLine);

                File.AppendAllText(@"\\195.96.246.33\automatic\DOWNKARL.TXT",
                    Environment.NewLine);

                File.AppendAllText(@"\\195.96.246.33\automatic\14_08_2008\DOWNKARL.TXT",
                    Environment.NewLine);

            }
        }
    }
}
