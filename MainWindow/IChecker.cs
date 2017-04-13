using System.Collections.Generic;

namespace MainWindow
{
    public interface IChecker
    {
        List<string> findWords(List<string> oldList, string text);
    }
}
