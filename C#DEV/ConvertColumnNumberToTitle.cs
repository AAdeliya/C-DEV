public class ConvertColumnNumberToTitles{
    public String convertColumnNumberToTitle (int columnNumber) {
    string ans = "";
    while (columnNumber> 0) {
        columnNumber--;
        ans  = ((char) ((columnNumber) % 26 + 'A')) + ans;
        columnNumber = (columnNumber) / 26;

    }

    return ans;
}


}