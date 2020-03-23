CREATE DATABASE  IF NOT EXISTS `unbk` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `unbk`;
-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: unbk
-- ------------------------------------------------------
-- Server version	5.5.5-10.1.29-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `akseskelas`
--

DROP TABLE IF EXISTS `akseskelas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `akseskelas` (
  `idKelas` int(11) NOT NULL,
  `idGuru` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `akseskelas`
--

LOCK TABLES `akseskelas` WRITE;
/*!40000 ALTER TABLE `akseskelas` DISABLE KEYS */;
INSERT INTO `akseskelas` VALUES (2,'Teach2017111'),(2,'Teach2017112'),(2,'Teach2017113'),(2,'Teach2017114'),(2,'Teach2017115'),(2,'Teach2017116'),(2,'Teach2017117'),(2,'Teach2017118'),(2,'Teach2017119'),(2,'Teach2017120');
/*!40000 ALTER TABLE `akseskelas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aksesmapel`
--

DROP TABLE IF EXISTS `aksesmapel`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `aksesmapel` (
  `idMapel` int(11) NOT NULL,
  `idGuru` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aksesmapel`
--

LOCK TABLES `aksesmapel` WRITE;
/*!40000 ALTER TABLE `aksesmapel` DISABLE KEYS */;
INSERT INTO `aksesmapel` VALUES (1,'Teach2017111'),(2,'Teach2017112'),(3,'Teach2017113'),(4,'Teach2017114'),(5,'Teach2017115'),(6,'Teach2017116'),(7,'Teach2017117'),(8,'Teach2017118'),(9,'Teach2017119'),(10,'Teach2017120');
/*!40000 ALTER TABLE `aksesmapel` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detailsoal`
--

DROP TABLE IF EXISTS `detailsoal`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detailsoal` (
  `idDetailSoal` int(11) NOT NULL AUTO_INCREMENT,
  `IdNoSoal` int(11) DEFAULT NULL,
  `pertanyaan` varchar(255) DEFAULT NULL,
  `jawabanA` varchar(255) DEFAULT NULL,
  `jawabanB` varchar(255) DEFAULT NULL,
  `jawabanC` varchar(255) DEFAULT NULL,
  `jawabanD` varchar(255) DEFAULT NULL,
  `jawabanE` varchar(255) DEFAULT NULL,
  `jawabanBenar` varchar(255) DEFAULT NULL,
  `idSoal` int(11) DEFAULT NULL,
  PRIMARY KEY (`idDetailSoal`)
) ENGINE=InnoDB AUTO_INCREMENT=74 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detailsoal`
--

LOCK TABLES `detailsoal` WRITE;
/*!40000 ALTER TABLE `detailsoal` DISABLE KEYS */;
INSERT INTO `detailsoal` VALUES (8,1,'Menurut hukum aksi reaksi, jika aksi menaikkan suhu sistem kesetimbangan, maka reaksi sistem menurunkan suhu. Pada kondisi ini, sistem bergeser ke.....\r\n','pihak yang melepas kalor ','pihak yang menyerap kalor             ','pihak konsentrasi tinggi',' pihak tekanan tinggi','pihak volume tinggi','B',11),(9,2,'Agar diperoleh gas HI sebanyak-banyaknya dari reaksi kesetimbangan: H2(g)  +  I2(g)        2HI(g)               ?H = +25,94 kJ/mol . Dapat dilakukan dengan cara…\r\n','pada suhu tetap, volume sistem diperbesar','pada suhu tetap, tekanan sistem diperkecil','pada suhu tetap, konsentrasi H2 diperkecil','suhu dinaikkan	','ditambah katalis','D',11),(10,3,'Perhatikan beberapa reaksi berikut ini :\n\r\n1.      Fotosintesis\r\n\n2.      Pembakaran\r\n\n3.      Respirasi\r\n\n4.      Pelelehan\n\r\nReaksi yang tergolong proses endoterm adalah ….\n','1 dan 2','1 dan 3','1 dan 4','2 dan 3','3 dan 4','C',11),(11,4,'Pencegahan korosi yang paling tepat pada setang sepeda adalah...','dihubungkan dengan magnesium','dilapisi dengan krom	','dioles dengan oli/minyak goreng	','proteksi katodik','dibuat paduan logam','B',11),(12,5,'Suatu senyawa mengandung 14% hidrogen dan 86% karbon. Jika Mr senyawa = 56, rumus empiris dan rumus molekul senyawa tersebut adalah …. (Ar H = 1 ; dan C = 12)','CH4 dan CH4\r\n','CH2dan C2H4','C3H4 dan C3H4	','CH2 DAN C4H8','C2H5 DAN C4H10','D',11),(13,1,'Diketahui rumus fungsi f (x) = 5x - 3. \r\nHasil dari f (3x+2) adalah....\r\n','8x - 1','15x -1','15x - 6','15x +7','8x+1','D',13),(14,2,'Dari 143 siswa, 95 siswa senang matematika, 87 siswa senang fisika, dan 60 siswa senang keduanya. Banyak siswa yang tidak senang matematika maupun fisika adalah ….','21 orang	','27 orang	','35 orang	\r\n','122 orang	','50 orang','A',13),(15,3,'Penyelesaian dari sistem persamaan x – 3y = 1 dan x – 2y = 2 adalah x dan y. Nilai 2x – 5y adalah','7','10','3','7','5','C',13),(16,4,'Suatu pekerjaan dapat diselesaikan oleh 15 pekerja dalam waktu 12 minggu. Jika pekerjaan itu harus selesai dalam 9 minggu, banyak pekerja yang harus ditambah adalah …','6 orang','4 orang',' 5 orang	','20 orang	','10 orang','C',13),(17,5,'Dua suku berikutnya dari barisan bilangan 20, 17, 13, 8, … adalah ….','5, 2\r\n','5, 0','2, –5','1, –8','3,-7','C',13),(18,1,'Menurut hukum aksi reaksi, jika aksi menaikkan suhu sistem kesetimbangan, maka reaksi sistem menurunkan suhu. Pada kondisi ini, sistem bergeser ke...','pihak yang melepas kalor     ','pihak yang menyerap kalor     ','pihak konsentrasi tinggi','pihak tekanan tinggi','pihak volume tinggi\r\n','B',14),(19,2,'Agar diperoleh gas HI sebanyak-banyaknya dari reaksi kesetimbangan: H2(g)  +  I2(g)        2HI(g)               ?H = +25,94 kJ/mol . Dapat dilakukan dengan cara…','pada suhu tetap, volume sistem diperbesar','pada suhu tetap, tekanan sistem diperkecil','pada suhu tetap, konsentrasi H2 diperkecil','suhu dinaikkan','ditambah katalis','D',14),(20,3,'\" Perhatikan beberapa reksi berikut ini :\r\n\n1.      Fotosintesis\r\n\n2.      Pembakaran\n\r\n3.      Respirasi\r\n\n4.      Pelelehan\r\n\nReaksi yang tergolong proses endoterm adalah ….\n','1 dan 2','1 dan 3','1 dan 4','2 dan 3','3 dan 4','C',14),(21,4,'Pencegahan korosi yang paling tepat pada setang sepeda adalah...','dihubungkan dengan magnesium','dilapisi dengan krom','dioles dengan oli/minyak goreng',' proteksi katodik','dibuat paduan logam\r\n','B',14),(22,5,'Suatu senyawa mengandung 14% hidrogen dan 86% karbon. Jika Mr senyawa = 56, rumus empiris dan rumus molekul senyawa tersebut adalah …. (Ar H = 1 ; dan C = 12)	...','CH4 dan CH4','CH2dan C2H4','C3H4 dan C3H4','CH2 DAN C4H8	','C2H5 DAN C4H10','D',14),(23,1,'A : Have you heard that Jono will come next week?    B : Oh, really? When did he tell you? A : Last week. The underlined sentence is used to express …	','happiness','surprise','pleasure','enjoyment','madness','B',15),(24,2,'Abibah arrives  at  school 06.15 am, she greets her teacher by saying ...\r\n','Hello','Good night','Good afternoon','Good morning  ','Good bye','D',15),(25,3,'I .... a fantastic film at the cinema last week.	','See',' seeing','seed','saw','Sawing\r\n','D',15),(26,4,'listen to everything . . . he saids	','which','who','whom','whos','why','A',15),(27,5,'Prayoga is a good person, he always kind to everybody. The synonym of  “good” is ….','Naughty	','Fine','Bad','Nice','Digger','D',15),(28,1,'Berikut ini yang menjadikan ciri khas dari drama adalah ….','konflik','tema','penokohan','dialog','amanat\r\n','D',16),(29,2,'Bendungan di Desa Jatirogo ini tidak ada duanya di Indonesia. Tubuh bendungan tersebut dari bantalan karet berisi air. Karena terbuat dari karet, tinggi permukaannya bisa diatur secara fleksibel. Bila terjadi banjir, bantalan karet itu dikempiskan. Dan ai','Bendungan dari bantalan karet dapat membendung sungai.','Bendungan dari bantalan karet sangat bermanfaat','Bendungan dari bantalan karet dapat mengalirkan air.','Pemanfaatan air melalui bendungan bantalan karet.','Bendungan bantalan karet dapat diisi dengan air','B',16),(30,3,'(1) Dengarkan angin mengusir batang-batang padi.(2) Sebelum matahari terbenam.(3) Dengarkan senandung di balik jendela.(4) Rumah kecil, bukanlah pintu pagarku. (4) Rumah kecil, bukanlah pintu pagarku. (5) Angin datang mengantarkan berita. Berdasarkan puis','(1) dan (2)','(1) dan (3)','(1) dan (2)		\r\n','(1) dan (5)','(1) dan (3)','D',16),(31,4,'Manajer perusahaan multiproduk itu berasal dari kalangan elit. Ia dalam manajemennya selalu menggunakan sistem kontrak.Dalam paragraf di atas, terdapat kesalahan penulisan kata serapan, yakni…	','manajer seharusnya manager','multiproduk seharusnya multiprodak','elit seharusnya elite','manajemen seharusnya managemen','sistem seharusnya sistim','B',16),(32,5,'5	Bacalah larik-larik puisi berikut!Buah mengkudu kusangka kandis, Kandis terletak dalam puan, Gula madu kusangka manis.Larik yang tepat untuk melengkapi pantun di atas adalah……','Senyum adinda memang manis	','Bunga melati banyak yang suka','Gula manis di dalam cawan','Bunga melati banyak yang suka	D. Kawan manis idaman hati','Manis lagi senyummu, Tuan\r\n','E',16),(33,1,'Irfan menembakkan peluru dengan kecepatan awal 120 m/s membentuk sudut elevasi 30° terhadap permukaan tanah. Jika g = 10 m/s2, peluru mencapai titik tertinggi setelah.....	','4 s','5 s','6 s','7 s','8 s\r\n','C',19),(34,2,'Benda massa m dan bergerak dengan kelajuan v maka benda dikatakan memiliki …..	    			\r\n','energi potensial    ','energi total','energi gerak ','energi kinetik 	','energi panas','D',19),(35,3,'Sebuah peluru ditembakkan dengan kecepatan 60 m/s dan sudut elevasi 30°. Ketinggian maksimum yang dicapai peluru adalah ....','30 m','45 m','50 m','90 m','100 m','B',19),(36,4,'Seorang pemain sepakbola menendang bola dengan sudut elevasi 60°. Jika bola bergerak dengan kecepatan awal 30 m/s, maka jarak pemain yang menerima umpan kiper tersebut mendekati ....','60 m','65 m	','70 m','75 m','78 m','E',19),(37,5,'Apabila besar sudut antara arah horizontal dan arah tembak suatu peluru adalah 53°, perbandingan antara jarak tembak dalam arah mendatar dengan tinggi maksimum peluru adalah .... (sin 53° = 4/5 )...','2 : 3 ','3 : 2 ','3 : 1','1 : 3 ',' 2 : 1','C',19),(38,1,'Teknik dasar permainan sepak bola adalah dengan...','direbut dan diambil','digiring lalu dipukul','digiring dan ditendang','diumpan lalu digelindingkan','diambil lalu ditembak','C',20),(39,2,'Pemain penyerang dalam permainan bola voli disebut . . . .','Set Upper','Smasher',' Blocker','Libero	','Reverse\r\n','B',20),(40,3,'Induk organisasi bola basket Indonesia adalah . . . .','PBSI','BASI','IPSI','PERBASI','PASI\r\n','D',20),(41,4,'Gerakan lay-up shoot diawali dengan langkah sebanyak berapa kali?','4 langkah','3 langkah','2 langkah','1 langkah','bebas dan tidak terbata\r\n','C',20),(42,5,'Penjagaan yang dilakukan  dengan sangat ketat dan tidak boleh meninggalkan lawan dalam sepak bola disebut juga dengan pola pertahanan ...	','kombinasi','zone defence	','man to man marking','free area marking','tight man defence','C',20),(43,1,' Ilmu yang mempelajari bagaimana hukum membaca Alquran dengan baik dan benar adalah ….','ilmu tauhid','ilmu nahwu','ilmu fiqih','ilmu tajwid',' ilmu saraf\r\n','D',21),(44,2,'Fungsi Kakbah adalah ….\r\n','ukuran kebaikan dan keburukan','arah melaksanakan ibadah','bangunan suci','untuk disembah','tempat berkumpulnya umat Islam','B',21),(45,3,'Kain kafan yang dipergunakan untuk menutupi jenazah hendaknya berwarna……','Abu-abu  ',' Merah','Pink','hijau','Putih\r\n','E',21),(46,4,'Kitab Allah yang diturunkan kepada Nabi Daud a.s. adalah....','Al-Qur’an                 ',' Taurat ',' Injil','Shuhuf	','Zabur\r\n','E',21),(47,5,'Hal pertama yang harus dilakukan apabila seorang muslim telah dipastikan meninggal dunia adalah…','Melemaskan seluruh persendian si mayat','Menutup sekujur tubuhnya dengan kain batik','Membagikan harta warisan',' Menyegerakan pengurusan jenazah','Menutup kedua mata si mayat','E',21),(48,1,' Perintah atau type masukkan untuk menampilkan berupa pilihan adalah:\r\n','Radio','Checkbox\r\n','Submit\r\n',' Resume\r\n','\r\nPassword\r\n','B',22),(49,2,' Perintah untuk mengganti baris pada HTML adalah\r\n','br','tr','p','td','insert','A',22),(50,3,'Awal dokumen html ditandai dengan adanya tag ....\r\n','<head>','<body>','<html>','<title>','</html>','C',22),(51,4,'kepanjangan php adalah','Personal Home Page\r\n','Personal Hourse Page\r\n','Personal Hours Page\r\n','Personal Hold Page\r\n','Persatuan Hiburan Onde-ondel\r\n','A',22),(52,5,'Struktur logika if terdiri dari 2 jenis, yaitu..\r\n','If ganjil dan genap\r\n','If tunggal dan ganda\r\n','If tunggal dan majemuk\r\n','If setara dan beringkat\r\n','if satu dan ganda\r\n','C',22),(53,1,'ada tahun 1908, mulailah berdiri dan berkembang organisasi-organisasi yang modern di Indonesia, berikut ini yang menjadi organisasi yang pertama kali terbentuk yaitu…\r\n','Indische Partij\r\n','Partai Nasional Indonesia (PNI)\r\n','budi utomo','Sarekat Islam\r\n','Partai Indonesia Raya (Parindra)\r\n','C',23),(54,2,' Maksud dibentuknya Panitia Sembilan oleh BPUPKI adalah....\r\n','menambah jumlah anggota BPUPKI\r\n','untuk membahas hasil sidang I BPUPKI tentang rancangan dasar negara\r\n','mempercepat proses kemerdekaan Indonesia\r\n','mempersiapkan materi sidang BPUPKI\r\n','sebagai penghubung antra BPUPKI dengan Jepang\r\n','B',23),(55,3,'Kondisi perekonomian Indonesia pada awal kemerdekaan adalah...\r\n','dibantu oleh negara bekas penjajah\r\n',' langsung membaik\r\n','angka inflasi berhasil ditekan\r\n','pendapatan pemerintah tidak seimbang dengan pengeluaran\r\n','langsung mendapat bantuan asing\r\n','D',23),(56,4,'Kabinet parlementer pertama yang dibentuk pada awal kemerdekaan dipimpin oleh Perdana Menteri....\r\n','Moh. Hatta\r\n','Ir. Soekarno\r\n','Amir Syarifuddin\r\n','Sutan Syahrir\r\n','Ali Sastroamijoyo\r\n','E',23),(57,5,' Maklumat Pemerintah tanggal 5 Oktober 1945 berisikan pembentukan organisasi ketentaraan yang bernama....\r\n','Badan Keamanan Rakyat\r\n','Tentara Keamanan Rakyat\r\n','Tentara Keselamatan Rakyat\r\n','Tentara Republik Indonesia\r\n\r\n','Tentara Nasional Indonesia\r\n','B',23),(58,1,'Proses terjadinya hubungan internasional adalah, kecuali :\r\n\r\n','persahabatan\r\n','persengketaan\r\n','permusuhan\r\n','ideologi\r\n','peperangan\r\n','D',24),(59,2,' Sumber dari segala sumber hukum di negara indonesi adalah....\r\n','Pancasila\r\n','Peraturan pemerintah\r\n','UUD 1945\r\n','Proklamasi kemerdekaan\r\n','Ketetapan MPR\r\n','A',24),(60,3,'Titik berat kerja sama ASEAN dalam bidang …\r\n','Politik, sosial, budaya\r\n',' Ekonomi, sosial, budaya\r\n','Ideologi, ekonomi, budaya\r\n','Ideologi, ekonomi, militer\r\n','Ideologi, sosial, budaya\r\n','B',24),(61,4,'Tujuan politik luar negeri Indonesia adalah …\r\n','Ikut aktif dalam berbagai kegiatan internasional\r\n','Memperhatikan kemerdekaan dan keamanan\r\n','Mendukung netralites wilayah internasional\r\n','Menciptakan masyarakat adil\r\n','Menggalang kerja sama negara yang netral\r\n','A',24),(62,5,'suatu ikatan hukum yang terjadi berdasarkan kata sepakat antara negara-negara sebagai anggota organisasi bangsa-bangsa dengan tujuan melaksanakan hukum tertentu yang mempunyai akibat hukum tertentu adalah\r\n','Organisasi Internasional\r\n','Hukum Internasional\r\n','Aliran positivisme\r\n','Palang merah internasional\r\n','Perjanjian Internasional\r\n','E',24),(63,1,'dv','d','dv','dvd','dv','vd','B',25),(64,2,'dv','d','dv','dvd','dv','vd','B',25),(65,3,'dv','d','dv','dvd','dv','vd','B',25),(66,4,'dv','d','dv','dvd','dv','vd','B',25),(67,5,'dv','d','dv','dvd','dv','vd','B',25),(68,6,'dv','d','dv','dvd','dv','vd','B',25),(69,7,'dv','d','dv','dvd','dv','vd','B',25),(70,8,'dv','d','dv','dvd','dv','vd','B',25),(71,1,'f','sdfewfe','weiogewug','z','f','f','D',26),(72,1,'gvregreg','v','edit','c','dav','rege','A',27),(73,2,'fwgerggg','v','wefinweginweg','edit','dav','rege','B',27);
/*!40000 ALTER TABLE `detailsoal` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `guru`
--

DROP TABLE IF EXISTS `guru`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `guru` (
  `idGuru` varchar(45) NOT NULL,
  `fullName` varchar(45) DEFAULT NULL,
  `password` varchar(45) DEFAULT NULL,
  `role` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idGuru`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `guru`
--

LOCK TABLES `guru` WRITE;
/*!40000 ALTER TABLE `guru` DISABLE KEYS */;
INSERT INTO `guru` VALUES ('Teach2017111','Dani Rustandi','dani123','guru'),('Teach2017112','Ikmal','ikmal123','guru'),('Teach2017113','Bayu Barokah','bayu123','guru'),('Teach2017114','Rahmathia Narang','rahmathia123','guru'),('Teach2017115','Rini Puji Lestari','rini123','guru'),('Teach2017116','Ira Rahmawati','ira123','guru'),('Teach2017117','Idit Salamun','idit123','guru'),('Teach2017118','Marwadi','marwadi123','guru'),('Teach2017119','Deti','deti123','guru'),('Teach2017120','Adithya Esa','esa123','guru');
/*!40000 ALTER TABLE `guru` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `headersoal`
--

DROP TABLE IF EXISTS `headersoal`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `headersoal` (
  `idSoal` int(11) NOT NULL AUTO_INCREMENT,
  `idMapel` int(11) DEFAULT NULL,
  `idGuru` varchar(45) DEFAULT NULL,
  `tglDibuat` datetime DEFAULT NULL,
  `jumlahSoal` int(11) DEFAULT NULL,
  `idKelas` int(11) DEFAULT NULL,
  `waktu` int(11) DEFAULT NULL,
  PRIMARY KEY (`idSoal`)
) ENGINE=InnoDB AUTO_INCREMENT=28 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `headersoal`
--

LOCK TABLES `headersoal` WRITE;
/*!40000 ALTER TABLE `headersoal` DISABLE KEYS */;
INSERT INTO `headersoal` VALUES (13,1,'Teach2017111','2018-04-18 00:00:00',5,2,600),(14,2,'Teach2017112','2018-04-18 00:00:00',5,2,600),(15,4,'Teach2017114','2018-04-18 00:00:00',5,2,600),(16,5,'Teach2017115','2018-04-18 00:00:00',5,2,600),(19,6,'Teach2017116','2018-04-19 00:00:00',5,2,600),(20,7,'Teach2017117','2018-04-19 00:00:00',5,2,600),(21,8,'Teach2017118','2018-04-19 00:00:00',5,2,600),(22,10,'Teach2017120','2018-04-20 00:00:00',5,2,600),(23,9,'Teach2017119','2018-04-20 00:00:00',5,2,600),(24,3,'Teach2017113','2018-04-20 00:00:00',5,2,600),(25,1,'Teach2017111','2018-04-22 00:00:00',8,2,800),(26,1,'Teach2017111','2018-04-23 00:00:00',1,2,300),(27,1,'Teach2017111','2018-04-23 00:00:00',2,2,600);
/*!40000 ALTER TABLE `headersoal` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `kelas`
--

DROP TABLE IF EXISTS `kelas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `kelas` (
  `idKelas` int(11) NOT NULL AUTO_INCREMENT,
  `namaKelas` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idKelas`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `kelas`
--

LOCK TABLES `kelas` WRITE;
/*!40000 ALTER TABLE `kelas` DISABLE KEYS */;
INSERT INTO `kelas` VALUES (1,'X'),(2,'XI'),(3,'XII');
/*!40000 ALTER TABLE `kelas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mapel`
--

DROP TABLE IF EXISTS `mapel`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `mapel` (
  `idMapel` int(11) NOT NULL AUTO_INCREMENT,
  `namaMapel` varchar(45) DEFAULT NULL,
  `kkm` int(11) DEFAULT NULL,
  PRIMARY KEY (`idMapel`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mapel`
--

LOCK TABLES `mapel` WRITE;
/*!40000 ALTER TABLE `mapel` DISABLE KEYS */;
INSERT INTO `mapel` VALUES (1,'Matematika',75),(2,'Kimia',74),(3,'PPKN',76),(4,'Inggris',75),(5,'Bahasa Indonesia',76),(6,'Fisika',75),(7,'Olah Raga',74),(8,'Agama Islam',76),(9,'Sejarah',75),(10,'Web Dinamis',75);
/*!40000 ALTER TABLE `mapel` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `siswa`
--

DROP TABLE IF EXISTS `siswa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `siswa` (
  `idSiswa` varchar(45) NOT NULL,
  `fullName` varchar(45) DEFAULT NULL,
  `kelas` varchar(45) DEFAULT NULL,
  `password` varchar(45) DEFAULT NULL,
  `role` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idSiswa`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `siswa`
--

LOCK TABLES `siswa` WRITE;
/*!40000 ALTER TABLE `siswa` DISABLE KEYS */;
INSERT INTO `siswa` VALUES ('Stud2016001','ACHMAD GAFFAR','XI','GAFFAR123','siswa'),('stud2016002','ADHAN MULYA','XI','ADHAN123','siswa'),('stud2016003','ADISTYA NOVITASARI','XI','ADIS123','siswa'),('stud2016004','AHMAD KASYFILLAH','XI','AHMAD123','siswa'),('stud2016005','AHMAD YUSRAN','XI','YUSRAN123','siswa'),('stud2016006','ALDIAN KURNIAWAN','XI','ALDIAN123','siswa'),('stud2016007','ANNISA MUTI\'AH','XI','ANNISA123','siswa'),('stud2016008','ARDIAN ZARKASIH','XI','ARDIAN123','siswa'),('stud2016009','ATIKAH HIJRIYANAH','XI','ATIKAH123','siswa'),('stud2016010','BAGAS ALFITO ','XI','BAGAS123','siswa'),('stud2016011','BAGUS SENO','XI','BAGUS123','siswa'),('stud2016012','DENIS HAKIMULLAH','XI','DENIS123','siswa'),('stud2016013','DINI AMANDA','XI','DINI123','siswa'),('stud2016014','DYLAN PASHAA','XI','DYLAN123','siswa'),('stud2016015','FIRSA ALDRIAN','XI','FIRSA123','siswa'),('stud2016016','GAZZA AL RABBANI','XI','GAZZA123','siswa'),('stud2016017','GILANG ADHI NUGRAHA','XI','GILANG123','siswa'),('stud2016018','HARRYS BANGKIT','XI','HARRYS123','siswa'),('stud2016019','HILMI FAUZAN ARHAM','XI','HILMI123','siswa'),('stud2016020','IRFAN AHMAD','XI','IRFAN123','siswa'),('stud2016021','JATRA ADI NUGRAHA','XI','JATRA123','siswa'),('stud2016022','KEVIN','XI','KEVIN123','siswa'),('stud2016023','LINGGA MUHAMMAD','XI','LINGGA123','siswa'),('stud2016024','MOUGY HANANTO PAMUNGKAS','XI','MOUGY123','siswa'),('stud2016025','M ZIDANE NAHLA QOWY','XI','ZIDAN123','siswa'),('stud2016026','NADHIF HAKIM','XI','NADHIF123','siswa'),('stud2016027','PRISCILLIA','XI','ICIL123','siswa'),('stud2016028','REYHAN YUDI','XI','REYHAN123','siswa'),('stud2016029','RIFQI NUR FAUZI','XI','RIFQI123','siswa'),('stud2016030','RIZKY PERDANA','XI','RIZKY123','siswa'),('stud2016031','SAILA MAHDINA TASHA','XI','SAILA123','siswa'),('stud2016032','SATRIA SETYA LAKSANA','XI','SATRIA123','siswa'),('stud2016033','SAUGI MOCHAMMAD','XI','SAUGI123','siswa'),('stud2016034','SUCI SOFYATI','XI','SUCI123','siswa'),('stud2016035','SYACH RYAN REZA','XI','SYACH123','siswa'),('stud2016036','SYIFA FAUZIAH','XI','SYIFA123','siswa'),('stud2016037','TEDY SEPTIANO','XI','TEDY123','siswa'),('stud2016038','WISNU ILHAM SETIANTO','XI','WISNU123','siswa'),('stud2016039','YOHANA KARTIKA','XI','YOHANA123','siswa'),('stud2016040','ZAHRA ATIKA CAHYANI','XI','ZAHRA123','siswa');
/*!40000 ALTER TABLE `siswa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ujian`
--

DROP TABLE IF EXISTS `ujian`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ujian` (
  `idUjian` int(11) NOT NULL AUTO_INCREMENT,
  `idSoal` varchar(45) DEFAULT NULL,
  `idSiswa` varchar(45) DEFAULT NULL,
  `tglPengerjaan` date DEFAULT NULL,
  `nilai` int(11) DEFAULT NULL,
  PRIMARY KEY (`idUjian`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ujian`
--

LOCK TABLES `ujian` WRITE;
/*!40000 ALTER TABLE `ujian` DISABLE KEYS */;
INSERT INTO `ujian` VALUES (1,'13','stud2016025','2018-04-20',20),(2,'21','stud2016025','2018-04-22',100),(3,'25','stud2016025','2018-04-22',96),(5,'25','stud2016002','2018-04-22',96),(6,'21','stud2016001','2018-04-22',100),(7,'25','stud2016001','2018-04-22',12),(8,'25','stud2016023','2018-04-22',100),(9,'14','stud2016025','2018-04-22',0),(10,'19','stud2016025','2018-04-22',40),(11,'15','stud2016025','2018-04-22',0),(12,'15','stud2016039','2018-04-23',20),(13,'14','stud2016039','2018-04-23',40),(14,'26','stud2016025','2018-04-23',0),(15,'24','stud2016025','2018-04-23',0),(16,'27','stud2016025','2018-04-23',50),(17,'','stud2016025','2018-04-23',100),(18,'23','stud2016025','2018-04-23',40),(19,'13','stud2016002','2018-04-23',20),(20,'26','stud2016002','2018-04-23',0);
/*!40000 ALTER TABLE `ujian` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-04-23 13:07:22
