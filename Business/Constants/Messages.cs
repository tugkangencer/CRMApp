namespace Business.Constants
{
    public static class Messages
    {
        public static string RequiredFields => "Lütfen muhatabın Ad, Soyad ve en az bir iletişim bilgisini giriniz.";
        public static string PhoneAlreadyExists => "Girmek istediğiniz telefon numarası ile uyuşan muhatap kaydı bulunmaktadır.";
        public static string CitizenNumberAlreadyExists => "Girmek istediğiniz TCKN ile uyuşan muhatap kaydı bulunmaktadır.";
        public static string InvalidPhone => "Telefon Numarası Hatalı";
        public static string InvalidCID => "TCKN Hatalı";
        public static string InvalidMail => "Geçersiz Mail Adresi";
        public static string Success => "Başarılı!";
    }
}
