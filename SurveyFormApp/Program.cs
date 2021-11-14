using SurveyFormApp.Abstracts;
using SurveyFormApp.Models;
using System;

namespace SurveyFormApp
{
    class Program
    {
        private static object shortQuestion;

        static void Main(string[] args)
        {
            Survey survey = new Survey(title: "Kişisel Sorular", name: "Mahmut", surname: "Tuncer", questionCount: 6);

            ShortQuestion s1 = new ShortQuestion(questionContent: "Kendinizi kısaca tanıtın?");
            YesOrNoQuestion y1 = new YesOrNoQuestion("Bekar mısınız?");
            ParagraphQuestion p1 = new ParagraphQuestion("Hayatınızı anlatır mısınız?");
            MultiChoiceQuestion m1 = new MultiChoiceQuestion("Hobileriniz nelerdir");
            DateQuestion d1 = new DateQuestion("Doğum tarihiniz Gün/ay/yıl şeklinde girer misiniz?");
            CheckBoxQuestion c1 = new CheckBoxQuestion("En sevdiğiniz spor dalı aşağıdakilerden hangisidir?");


            // soru sayısı kontroloü yapıldı
            survey.AddQuestion(s1);
            survey.AddQuestion(y1);
            survey.AddQuestion(p1);
            survey.AddQuestion(m1);
            survey.AddQuestion(d1);
            survey.AddQuestion(c1);




            // Onay kutusu seçenek sayısı kontrol edildi 2 den fazla seçenek olmalı aynı seçenekten eklenemez Hiçbiri girildiğinde diğer seçimleri silip hiçbiriyi alıyor 
            #region
            //c1.AddChoice("Futbol");
            //c1.AddChoice("Tenis");
            //c1.AddChoice("Basketbol");
            //c1.AddChoice("Hentbol");
            //c1.AddChoice("Hiçbiri");
            //c1.AddAnswer("Futbol");
            //c1.AddAnswer("Hiçbiri");
            #endregion


            // Kısa Yanıt test edildi birden fazla yanıt verilemez ve 30 karakteri aşamaz.
            #region
            //s1.AddAnswer("Adın Mahmut Tuncer");
            //s1.AddAnswer("Adım Berkay Erarslan");
            #endregion


            // Paragraf test edildi birden fazla yanıt verilemez ve 200 karakteri aşamaz.
            #region
            //p1.AddAnswer("Adın Mahmut Tuncer");
            //p1.AddAnswer("Adım Berkay Erarslan");
            #endregion


            // Çoktan seçmeli soru test edildi aynı seçenekten eklenemez 4 den fazla seçenek olamaz ve 2 adet cevap eklenemez verilen cevap seçeneklerde yoksa eklenemez ve 1 den az seçenek varsa seçenek talebi oluşturur.
            #region
            //m1.AddChoice("Yüzmek");
            //m1.AddChoice("Koşmak");
            //m1.AddChoice("Sinema");
            //m1.AddChoice("Sinema");
            //m1.AddChoice("Tiyatro");
            //m1.AddChoice("Kod yazmak");
            //m1.AddAnswer("Yüzmek");
            //m1.AddAnswer("Sineme");
            #endregion


            // Tarih sorusu test edildi kullanıcı istediğimiz formatı girmeye zorunlu hatalı giriş kontrolleri doğru şekilde yapıldı.
            #region
            //d1.AddAnswer("32130102");
            //d1.AddAnswer("01/02/1996");

            #endregion


            // Evet Hayır anketi test edildi
            #region
            //y1.AddChoice(y1.Yes);
            //y1.AddChoice(y1.No);
            //y1.AddAnswer(y1.Yes);

            #endregion




        }
    }
}
