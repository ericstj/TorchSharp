using System;
using System.IO;

namespace ConsoleApp2
{
    public class Program
    {

        public static void Restitch(string RestitcherPackage)
        {
            // !!!!!!!------------------------------NOTE------------------------------------!!!!!!
            // !!!!!!! This code is manually copied into pkg\common\RestitchPackage.targets !!!!!!
            // !!!!!!!------------------------------NOTE------------------------------------!!!!!!
            //
            // vvvvvvvvvvvvvvvvvvvvvvvvvvvvv START HERE vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv
            try {
                if (Directory.Exists(RestitcherPackage)) {
                    //System.Console.WriteLine("Searching for primary files in {0}", RestitcherPackage);
                    foreach (var p in Directory.EnumerateFiles(RestitcherPackage, "*", SearchOption.AllDirectories)) {

                        var primaryFile = Path.GetFullPath(p);
                        //Console.WriteLine("Found primary file at {0}", primaryFile);

                        // See if there are fragments in the parallel nuget packages. If the primary is 
                        //        some-package-primary\runtimes\....\a.so 
                        //        some-package-primary\runtimes\....\a.so.sha
                        // then the expected fragments are
                        //        some-package-fragment1\fragments\....\a.so 
                        //        some-package-fragment2\fragments\....\a.so 
                        //        some-package-fragment3\fragments\....\a.so 
                        //        some-package-fragment4\fragments\....\a.so 
                        //        some-package-fragment5\fragments\....\a.so 
                        //        some-package-fragment6\fragments\....\a.so 
                        //        some-package-fragment7\fragments\....\a.so 
                        //        some-package-fragment8\fragments\....\a.so 
                        //        some-package-fragment9\fragments\....\a.so 
                        //        some-package-fragment10\fragments\....\a.so 
                        var shaFile = primaryFile + ".sha";
                        var fragmentFile1 = primaryFile.Replace("-primary", "-fragment1").Replace("runtimes", "fragments") + ".fragment1";
                        var fragmentFile2 = primaryFile.Replace("-primary", "-fragment2").Replace("runtimes", "fragments") + ".fragment2";
                        var fragmentFile3 = primaryFile.Replace("-primary", "-fragment3").Replace("runtimes", "fragments") + ".fragment3";
                        var fragmentFile4 = primaryFile.Replace("-primary", "-fragment4").Replace("runtimes", "fragments") + ".fragment4";
                        var fragmentFile5 = primaryFile.Replace("-primary", "-fragment5").Replace("runtimes", "fragments") + ".fragment5";
                        var fragmentFile6 = primaryFile.Replace("-primary", "-fragment6").Replace("runtimes", "fragments") + ".fragment6";
                        var fragmentFile7 = primaryFile.Replace("-primary", "-fragment7").Replace("runtimes", "fragments") + ".fragment7";
                        var fragmentFile8 = primaryFile.Replace("-primary", "-fragment8").Replace("runtimes", "fragments") + ".fragment8";
                        var fragmentFile9 = primaryFile.Replace("-primary", "-fragment9").Replace("runtimes", "fragments") + ".fragment9";
                        var fragmentFile10 = primaryFile.Replace("-primary", "-fragment10").Replace("runtimes", "fragments") + ".fragment10";

                        if (File.Exists(fragmentFile1)) Console.WriteLine("Found fragment file at {0}", fragmentFile1);
                        if (File.Exists(fragmentFile2)) Console.WriteLine("Found fragment file at {0}", fragmentFile2);
                        if (File.Exists(fragmentFile3)) Console.WriteLine("Found fragment file at {0}", fragmentFile3);
                        if (File.Exists(fragmentFile4)) Console.WriteLine("Found fragment file at {0}", fragmentFile4);
                        if (File.Exists(fragmentFile5)) Console.WriteLine("Found fragment file at {0}", fragmentFile5);
                        if (File.Exists(fragmentFile6)) Console.WriteLine("Found fragment file at {0}", fragmentFile6);
                        if (File.Exists(fragmentFile7)) Console.WriteLine("Found fragment file at {0}", fragmentFile7);
                        if (File.Exists(fragmentFile8)) Console.WriteLine("Found fragment file at {0}", fragmentFile8);
                        if (File.Exists(fragmentFile9)) Console.WriteLine("Found fragment file at {0}", fragmentFile9);
                        if (File.Exists(fragmentFile10)) Console.WriteLine("Found fragment file at {0}", fragmentFile10);

                        if (File.Exists(fragmentFile1)) {
                            var tmpFile = Path.GetTempFileName();

                            {
                                Console.WriteLine("Writing restored primary file at {0}", tmpFile);
                                using (var os = File.OpenWrite(tmpFile)) {

                                    Console.WriteLine("Writing bytes from {0} to {1}", primaryFile, tmpFile);
                                    var primaryBytes = File.ReadAllBytes(primaryFile);

                                    os.Write(primaryBytes, 0, primaryBytes.Length);
                                    if (File.Exists(fragmentFile1)) {
                                        Console.WriteLine("Writing fragment bytes from {0} to {1}", fragmentFile1, tmpFile);
                                        var fragmentBytes1 = File.ReadAllBytes(fragmentFile1);
                                        os.Write(fragmentBytes1, 0, fragmentBytes1.Length);
                                    }
                                    if (File.Exists(fragmentFile2)) {
                                        Console.WriteLine("Writing fragment bytes from {0} to {1}", fragmentFile2, tmpFile);
                                        var fragmentBytes2 = File.ReadAllBytes(fragmentFile2);
                                        os.Write(fragmentBytes2, 0, fragmentBytes2.Length);
                                    }
                                    if (File.Exists(fragmentFile3)) {
                                        Console.WriteLine("Writing fragment bytes from {0} to {1}", fragmentFile3, tmpFile);
                                        var fragmentBytes3 = File.ReadAllBytes(fragmentFile3);
                                        os.Write(fragmentBytes3, 0, fragmentBytes3.Length);
                                    }
                                    if (File.Exists(fragmentFile4)) {
                                        Console.WriteLine("Writing fragment bytes from {0} to {1}", fragmentFile4, tmpFile);
                                        var fragmentBytes4 = File.ReadAllBytes(fragmentFile4);
                                        os.Write(fragmentBytes4, 0, fragmentBytes4.Length);
                                    }
                                    if (File.Exists(fragmentFile5)) {
                                        Console.WriteLine("Writing fragment bytes from {0} to {1}", fragmentFile5, tmpFile);
                                        var fragmentBytes5 = File.ReadAllBytes(fragmentFile5);
                                        os.Write(fragmentBytes5, 0, fragmentBytes5.Length);
                                    }
                                    if (File.Exists(fragmentFile6)) {
                                        Console.WriteLine("Writing fragment bytes from {0} to {1}", fragmentFile6, tmpFile);
                                        var fragmentBytes6 = File.ReadAllBytes(fragmentFile6);
                                        os.Write(fragmentBytes6, 0, fragmentBytes6.Length);
                                    }
                                    if (File.Exists(fragmentFile7)) {
                                        Console.WriteLine("Writing fragment bytes from {0} to {1}", fragmentFile7, tmpFile);
                                        var fragmentBytes7 = File.ReadAllBytes(fragmentFile7);
                                        os.Write(fragmentBytes7, 0, fragmentBytes7.Length);
                                    }
                                    if (File.Exists(fragmentFile8)) {
                                        Console.WriteLine("Writing fragment bytes from {0} to {1}", fragmentFile8, tmpFile);
                                        var fragmentBytes8 = File.ReadAllBytes(fragmentFile8);
                                        os.Write(fragmentBytes8, 0, fragmentBytes8.Length);
                                    }
                                    if (File.Exists(fragmentFile9)) {
                                        Console.WriteLine("Writing fragment bytes from {0} to {1}", fragmentFile9, tmpFile);
                                        var fragmentBytes9 = File.ReadAllBytes(fragmentFile9);
                                        os.Write(fragmentBytes9, 0, fragmentBytes9.Length);
                                    }
                                    if (File.Exists(fragmentFile10)) {
                                        Console.WriteLine("Writing fragment bytes from {0} to {1}", fragmentFile10, tmpFile);
                                        var fragmentBytes10 = File.ReadAllBytes(fragmentFile10);
                                        os.Write(fragmentBytes10, 0, fragmentBytes10.Length);
                                    }
                                }
                            }

                            var shaExpected = File.Exists(shaFile) ? File.ReadAllText(shaFile) : "";

                            using (var sha256Hash = System.Security.Cryptography.SHA256.Create()) {
                                using (var os2 = File.OpenRead(tmpFile)) {

                                    byte[] bytes = sha256Hash.ComputeHash(os2);
                                    var builder = new System.Text.StringBuilder();
                                    for (int i = 0; i < bytes.Length; i++) {
                                        builder.Append(bytes[i].ToString("x2"));
                                    }
                                    var shaReconstituted = builder.ToString();
                                    if (shaExpected != shaReconstituted) {
                                        string msg =
                                                $"Error downloading and reviving packages. Reconsituted file contents have incorrect SHA\n\tExpected SHA: ${shaExpected}\n\tActual SHA: ${shaReconstituted}\n\tFile was reconstituted from:"
                                              + $"\n\t{primaryFile} (length ${new FileInfo(primaryFile).Length})"
                                              + (File.Exists(fragmentFile1) ? $"\n\t{fragmentFile1} (length ${new FileInfo(fragmentFile1).Length})" : "")
                                              + (File.Exists(fragmentFile2) ? $"\n\t{fragmentFile2} (length ${new FileInfo(fragmentFile2).Length})" : "")
                                              + (File.Exists(fragmentFile3) ? $"\n\t{fragmentFile3} (length ${new FileInfo(fragmentFile3).Length})" : "")
                                              + (File.Exists(fragmentFile4) ? $"\n\t{fragmentFile4} (length ${new FileInfo(fragmentFile4).Length})" : "")
                                              + (File.Exists(fragmentFile5) ? $"\n\t{fragmentFile5} (length ${new FileInfo(fragmentFile5).Length})" : "")
                                              + (File.Exists(fragmentFile6) ? $"\n\t{fragmentFile6} (length ${new FileInfo(fragmentFile6).Length})" : "")
                                              + (File.Exists(fragmentFile7) ? $"\n\t{fragmentFile7} (length ${new FileInfo(fragmentFile7).Length})" : "")
                                              + (File.Exists(fragmentFile8) ? $"\n\t{fragmentFile8} (length ${new FileInfo(fragmentFile8).Length})" : "")
                                              + (File.Exists(fragmentFile9) ? $"\n\t{fragmentFile9} (length ${new FileInfo(fragmentFile9).Length})" : "")
                                              + (File.Exists(fragmentFile10) ? $"\n\t{fragmentFile10} (length ${new FileInfo(fragmentFile10).Length})" : "");
                                        Console.Error.WriteLine(msg);
                                        throw new Exception(msg);
                                    }
                                }

                            }

                            Console.WriteLine("Deleting {0}", primaryFile);
                            File.Delete(primaryFile);
                            if (File.Exists(primaryFile))
                                throw new Exception("wtf?");

                            Console.WriteLine("Moving {0} --> {1}", tmpFile, primaryFile);
                            File.Move(tmpFile, primaryFile);

                            Console.WriteLine("Deleting {0}", fragmentFile1);
                            File.Delete(fragmentFile1);  // free up space and prevent us doing this again 

                            Console.WriteLine("Deleting {0}", fragmentFile2);
                            if (File.Exists(fragmentFile2))
                                File.Delete(fragmentFile2);  // free up space and prevent us doing this again 

                            Console.WriteLine("Deleting {0}", fragmentFile3);
                            if (File.Exists(fragmentFile3))
                                File.Delete(fragmentFile3);  // free up space and prevent us doing this again 

                            Console.WriteLine("Deleting {0}", fragmentFile4);
                            if (File.Exists(fragmentFile4))
                                File.Delete(fragmentFile4);  // free up space and prevent us doing this again 

                            Console.WriteLine("Deleting {0}", fragmentFile5);
                            if (File.Exists(fragmentFile5))
                                File.Delete(fragmentFile5);  // free up space and prevent us doing this again 

                            Console.WriteLine("Deleting {0}", fragmentFile6);
                            if (File.Exists(fragmentFile6))
                                File.Delete(fragmentFile6);  // free up space and prevent us doing this again 

                            Console.WriteLine("Deleting {0}", fragmentFile7);
                            if (File.Exists(fragmentFile7))
                                File.Delete(fragmentFile7);  // free up space and prevent us doing this again 

                            Console.WriteLine("Deleting {0}", fragmentFile8);
                            if (File.Exists(fragmentFile8))
                                File.Delete(fragmentFile8);  // free up space and prevent us doing this again 

                            Console.WriteLine("Deleting {0}", fragmentFile9);
                            if (File.Exists(fragmentFile9))
                                File.Delete(fragmentFile9);  // free up space and prevent us doing this again 

                            Console.WriteLine("Deleting {0}", fragmentFile10);
                            if (File.Exists(fragmentFile10))
                                File.Delete(fragmentFile10);  // free up space and prevent us doing this again 
                        }
                    }
                }
            }
            catch (Exception ex) {
                Console.Error.WriteLine(ex.ToString());
                Console.Error.WriteLine(ex.StackTrace);
            }
            // ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ END HERE^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        }
    }
}
