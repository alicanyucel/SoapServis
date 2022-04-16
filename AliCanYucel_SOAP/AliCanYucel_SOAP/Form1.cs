using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Xml;
using System.Net;
using System.IO;
using System.Windows.Forms;
using System.Net.Http;

namespace AliCanYucel_SOAP
{
    public partial class Form1 : Form
    {
        const string servisUrl = "http://10.20.30.125:8000/sap/bc/srt/rfc/sap/zsd_ws_create_sales_order/100/zsd_ws_create_sales_order/zsd_ws_create_sales_order";
        const string kullanilacakActionUrl = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void WebServiseBaglanVeXmlGonder()
        {
            XmlDocument xmlDokuman = XmlDokumanOlustur();
            HttpWebRequest webRequest = RequestOlustur(servisUrl, kullanilacakActionUrl);
            WebRequestIcerikEkle(xmlDokuman, webRequest);

            try
            {
                IAsyncResult cevap = webRequest.BeginGetResponse(null, null);
                cevap.AsyncWaitHandle.WaitOne();

                string xmlCevap;
                using (WebResponse webResponse = webRequest.EndGetResponse(cevap))
                {
                    using (StreamReader streamReader = new StreamReader(webResponse.GetResponseStream()))
                    {
                        xmlCevap = streamReader.ReadToEnd();
                    }
                    txtGelenCevap.Text = xmlCevap;
                }
            }
            catch (Exception hata)
            {
                txtHata.AppendText("Metod [WebServiseBaglanVeGonder] Hata : \r\n" + hata.Message);
                txtHata.AppendText(Environment.NewLine);
                txtHata.AppendText(Environment.NewLine);
            }


        }

        private HttpWebRequest RequestOlustur(string _servisUrl, string _kullanilacakActionUrl)
        {
            
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(_servisUrl);

            try
            {
                webRequest.Headers.Add("SOAPAction", _kullanilacakActionUrl);
                webRequest.ContentType = "text/xml;charset=\"utf-8\"";
                webRequest.Accept = "text/xml";
                webRequest.Method = "POST";
            }
            catch (Exception hata)
            {
                txtHata.AppendText("Metod [RequestOlustur] Hata : \r\n" + hata.Message);
                txtHata.AppendText(Environment.NewLine);
                txtHata.AppendText(Environment.NewLine);
            }
            
            
            return webRequest;
        }

        private void WebRequestIcerikEkle(XmlDocument xmlDokuman, HttpWebRequest webRequest)
        {
            try
            {
                using (Stream stream = webRequest.GetRequestStream())
                {
                    xmlDokuman.Save(stream);
                }
            }
            catch (Exception hata)
            {
                txtHata.AppendText("Metod [WebRequestIcerikEkle] Hata : \r\n"+hata.Message);
                txtHata.AppendText(Environment.NewLine);
                txtHata.AppendText(Environment.NewLine);
            }

        }

       
        private XmlDocument XmlDokumanOlustur()
        {
            XmlDocument xmlDokuman = new XmlDocument();
            var xmlBilgi = @"<?xml version=""1.0"" encoding=""UTF - 8""?>
 <soapenv:Envelope xmlns:soapenv = 'http://schemas.xmlsoap.org/soap/envelope/' xmlns:urn = 'urn:sap-com:document:sap:soap:functions:mc-style'>
        <soapenv:Header></soapenv:Header>
         <soapenv:Body>       
             <urn:Zsd002FmCreateSalesOrder>         
                 <!--Optional:-->          
                  <ItAddress>          
                     <!--Zero or more repetitions:-->            
                       <item>            
                         <Source>TEKNOLIST</Source>            
                          <Guid>1000000079</Guid>            
                          <GuidVer />            
                          <Parvw>WE</Parvw>            
                          <AddrNo>1</AddrNo>            
                          <Formofaddr />            
                          <Name />
                          <Name2 />
                          <Name3 />
                          <Name4 />
                          <COName />
                          <City>İSTANBUL</City>
                          <District>ATAŞEHİR</District>
                          <CityNo />
                          <PostlCod1 />
                          <PostlCod2 />
                          <PostlCod3 />
                          <PoBox />
                          <PoBoxCit />
                          <DelivDis />
                          <Street>İÇERENKÖY MAHALLESI 2893 SOKAK NO 1</Street>
                          <StreetNo />
                          <StrAbbr />
                          <HouseNo />
                          <StrSuppl1 />
                          <StrSuppl2 />
                          <Location />
                          <Building />
                          <Floor />
                          <RoomNo />
                          <Country>TR</Country>
                          <Langu>T</Langu>
                          <Region>34</Region>
                          <Sort1 />
                          <Sort2 />
                          <TimeZone />
                          <Taxjurcode />
                          <AdrNotes />
                          <CommType />
                          <Tel1Numbr />
                          <Tel1Ext />
                          <FaxNumber />
                          <FaxExtens />
                          <StreetLng />
                          <DistrctNo />             
                          <Chckstatus />
                          <PboxcitNo />
                          <Transpzone />
                          <HouseNo2 />
                          <EMail />
                          <StrSuppl3 />
                          <Title />
                          <Countryiso />
                          <LanguIso />
                          <BuildLong />
                          <Regiogroup />
                          <HomeCity />
                          <Homecityno />
                          <Pcode1Ext />
                          <Pcode2Ext />
                          <Pcode3Ext />
                          <PoWONo />
                          <PoBoxReg />
                          <PoboxCtry />
                          <PoCtryiso />
                          <Homepage />
                          <DontUseS />
                          <DontUseP />
                          <HouseNo3 />
                          <LanguCr />
                          <Langucriso />
                          <PoBoxLobby />
                          <DeliServType />
                          <DeliServNumber />
                          <UriType />
                          <CountyCode />
                          <County />
                          <TownshipCode />
                          <Township />
                          <Xpcpt />
                       </item>
                    </ItAddress>
               
                       <!--Optional:-->
                
                        <ItHeader>
                
                           <!--Zero or more repetitions:-->
                  
                             <item>
                  
                              <Source>TEKNOLIST</Source>
                  
                                <Guid>1000000079</Guid>
                  
                                <GuidVer />
                  
                                <PoId>CUSTOMER REF02</PoId>
                     
                                   <Auart>ZM01</Auart>
                     
                                   <Vkorg>2920</Vkorg>
                     
                                   <Vtweg>10</Vtweg>
                     
                                   <Spart>10</Spart>
                     
                                   <Vkbur>2920</Vkbur>
                     
                                   <Vgbel />
                     
                                   <Vgtyp />
                     
                                   <Waerk>TRY</Waerk>
                     
                                   <Audat>20220201</Audat>
                     
                                   <Vdatu>20220202</Vdatu>
                     
                                   <CargoNo>1234567890</CargoNo>
                     
                                   <ShpComp>MNG KARGO</ShpComp>
                        
                                      <Annotation />
                        
                                      <Vbeln />
                        
                                      <ErrorText />
                        
                                   </item>
                        
                                </ItHeader>
                        
                                <!--Optional:-->
                         
                                 <ItKalem>
                         
                                    <!--Zero or more repetitions:-->
                           
                                      <item>
                           
                                         <Source>TEKNOLIST</Source>
                           
                                         <Guid>1000000079</Guid>
                           
                                         <GuidVer />
                           
                                         <Posnr>000010</Posnr>
                           
                                         <Vgbel />
                           
                                         <Vgpos />
                           
                                         <Vgtyp />
                           
                                         <Matnr>3000000015</Matnr>
                           
                                         <Kdmat>MTKSA4FCS060</Kdmat>
                           
                                         <KdmatShortText>Deneme Ürün</KdmatShortText>
                              
                                            <Kwmeng>100</Kwmeng>
                              
                                            <Vrkme>ST</Vrkme>
                              
                                            <Kschl>TRY</Kschl>
                              
                                            <Kbetr />
                              
                                            <Waers>TRY</Waers>
                              
                                            <Vbeln />
                              
                                            <Text />
                              
                                            <PageNum>10</PageNum>
                              
                                         </item>
                              
                                      </ItKalem>
                              
                                      <!--Optional:-->
                               
                                       <ItMuhatap>
                               
                                          <!--Zero or more repetitions:-->
                                 
                                            <item>
                                 
                                              <Source>TEKNOLIST</Source>
                                 
                                               <Guid>1000000079</Guid>
                                 
                                               <GuidVer />
                                 
                                               <Parvw>SV</Parvw>
                                 
                                               <Kunnr>1000000004</Kunnr>
                                 
                                               <Vbeln />
                                 
                                               <PoId />
                                 
                                            </item>
                                 
                                             <item>
                                 
                                              <Source>TEKNOLIST</Source>
                                 
                                               <Guid>1000000079</Guid>
                                 
                                               <GuidVer />
                                 
                                               <Parvw>MG</Parvw>
                                 
                                               <Kunnr>1000000004</Kunnr>
                                 
                                               <Vbeln />
                                 
                                               <PoId />
                                 
                                            </item>
                                 
                                         </ItMuhatap>
                                 
                                         <!--Optional:-->
                                  
                                          <IvSimulation>X</IvSimulation>
                                  
                                       </urn:Zsd002FmCreateSalesOrder>
                                   
                                     </soapenv:Body>
                                   </soapenv:Envelope>
";
            
            try
            {
                xmlDokuman.LoadXml(xmlBilgi);
            }
            catch (Exception hata)
            {
                txtHata.AppendText("Metod [XmlDokumanOlustur] Hata : \r\n" + hata.Message);
                txtHata.AppendText(Environment.NewLine);
                txtHata.AppendText(Environment.NewLine);
            }
            
            return xmlDokuman;
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnBaglantiTest_Click(object sender, EventArgs e)
        {
            txtGelenCevap.Clear();
            var client = new HttpClient();
            txtGelenCevap.Text = "Bağlantı Kuruluyor Lütfen Bekleyiniz...";
            try
            {
                var cevap = await client.SendAsync(new HttpRequestMessage(HttpMethod.Head, servisUrl));
                txtGelenCevap.AppendText(cevap.ToString());
            }
            catch (Exception hata)
            {
                txtGelenCevap.Clear();
                txtHata.AppendText("Bağlantı Test Hata : \r\n" + hata.ToString());
                txtHata.AppendText(Environment.NewLine);
                txtHata.AppendText(Environment.NewLine);
            }
            
        }

        private void btnXmlVeriGonder_Click(object sender, EventArgs e)
        {
            txtHata.Clear();
            txtGelenCevap.Clear();
            WebServiseBaglanVeXmlGonder();
        }

        private void btnJsonVeriGonder_Click(object sender, EventArgs e)
        {
            txtHata.Clear();
            txtGelenCevap.Clear();
        }
    }
}
