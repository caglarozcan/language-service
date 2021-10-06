Diğer API'lara dil desteği sağlayacak web servis. Data ve Core katmanları API için gerekli kaynakları sunmaktadır. Data katmanı içerisinde entityframework için DBContext yapılandırması ve repository yapılandırması bulunur. Core katmanı içerisinde ise işlemleri yerine getirecek olan iş mantıkları yazılmıştır. Bu katmanlardaki bileşenler Dil API'sine Dependency Injection ile dahil edilir.

Dil bilgisi almak için Languages tablosunda tanımlanmış olan dilin Key bilgisini ve Translations tablosundaki çeviri metnini ifade eden Key bilgisini göndermek gerekir.
