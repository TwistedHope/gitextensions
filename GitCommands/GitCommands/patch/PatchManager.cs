
                List<string> fileLines = new List<string>();
                foreach (string s in LoadFile(patch.FileNameA).Split('\n'))
                {
                    fileLines.Add(s);
                }

        public void LoadPatch(string text, bool applyPatch)
        {
            try{
            StringReader stream = new StringReader(text);
            LoadPatchStream(stream, applyPatch);
            }
            catch
            {
            }

        }

            try
            {
                StreamReader re = File.OpenText(PatchFileName);
                LoadPatchStream(re, true);
            }
            catch
            {
            }
        }

        public void LoadPatchStream(TextReader re, bool applyPatch)
        {

                        //WTF! No change
                        if (input.StartsWith("diff --git "))
                        {
                            //No change? lets continue to the next line
                            continue;
                        }

                    if (input.StartsWith("--- a/") && !input.StartsWith("--- /dev/null"))
            if (applyPatch)
                foreach (Patch patchApply in patches)
                {
                    if (patchApply.Apply == true)
                        ApplyPatch(patchApply);
                }