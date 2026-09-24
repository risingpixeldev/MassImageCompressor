using System;
using System.Collections.Generic;
using System.Text;

namespace NeoFotonCommon
{
	public interface IImageCompressorPresenter
	{
		IImgCompressorView View { get; set; }

        string GetPreviewImage(List<string> previewedImages, bool? next);
        int CompressDirectory(string dirPath, ReportProgress progress, bool overwrite);
        int CompressFiles(List<string> filePaths, ReportProgress progress);
	}

    public delegate void ReportProgress(int progress);
}
