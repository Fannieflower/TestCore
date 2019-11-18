using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace com.vip.vop.vcloud.product{
	
	
	public class ProductAdminServiceHelper {
		
		
		
		public class deleteEmailConfig_args {
			
			///<summary>
			/// 合作伙伴id
			///</summary>
			
			private string partnerId_;
			
			///<summary>
			/// 邮件地址信息
			///</summary>
			
			private string email_;
			
			public string GetPartnerId(){
				return this.partnerId_;
			}
			
			public void SetPartnerId(string value){
				this.partnerId_ = value;
			}
			public string GetEmail(){
				return this.email_;
			}
			
			public void SetEmail(string value){
				this.email_ = value;
			}
			
		}
		
		
		
		
		public class deleteFileLogSettingByPrimaryKey_args {
			
			///<summary>
			/// 主键id
			///</summary>
			
			private long? id_;
			
			public long? GetId(){
				return this.id_;
			}
			
			public void SetId(long? value){
				this.id_ = value;
			}
			
		}
		
		
		
		
		public class deleteHostByPrimaryKey_args {
			
			///<summary>
			/// 主键id
			///</summary>
			
			private long? id_;
			
			public long? GetId(){
				return this.id_;
			}
			
			public void SetId(long? value){
				this.id_ = value;
			}
			
		}
		
		
		
		
		public class deleteProductByPartner_args {
			
			///<summary>
			/// 合作伙伴id
			///</summary>
			
			private long? partnerId_;
			
			public long? GetPartnerId(){
				return this.partnerId_;
			}
			
			public void SetPartnerId(long? value){
				this.partnerId_ = value;
			}
			
		}
		
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class listAllFileLogSettings_args {
			
			
		}
		
		
		
		
		public class listHosts_args {
			
			///<summary>
			/// 合作伙伴id
			///</summary>
			
			private long? partnerId_;
			
			public long? GetPartnerId(){
				return this.partnerId_;
			}
			
			public void SetPartnerId(long? value){
				this.partnerId_ = value;
			}
			
		}
		
		
		
		
		public class pushPriceToVdgByIdList_args {
			
			///<summary>
			/// 价格id列表
			///</summary>
			
			private List<string> idList_;
			
			public List<string> GetIdList(){
				return this.idList_;
			}
			
			public void SetIdList(List<string> value){
				this.idList_ = value;
			}
			
		}
		
		
		
		
		public class pushProductToVdgBySkuIdList_args {
			
			///<summary>
			/// 商品skuId列表
			///</summary>
			
			private List<string> skuIdList_;
			
			public List<string> GetSkuIdList(){
				return this.skuIdList_;
			}
			
			public void SetSkuIdList(List<string> value){
				this.skuIdList_ = value;
			}
			
		}
		
		
		
		
		public class pushProductToVdgBySpuIdList_args {
			
			///<summary>
			/// 商品spuId列表
			///</summary>
			
			private List<string> spuIdList_;
			
			public List<string> GetSpuIdList(){
				return this.spuIdList_;
			}
			
			public void SetSpuIdList(List<string> value){
				this.spuIdList_ = value;
			}
			
		}
		
		
		
		
		public class saveEmailConfig_args {
			
			///<summary>
			/// 邮件地址配置
			///</summary>
			
			private com.vip.vop.vcloud.product.EmailConfig config_;
			
			public com.vip.vop.vcloud.product.EmailConfig GetConfig(){
				return this.config_;
			}
			
			public void SetConfig(com.vip.vop.vcloud.product.EmailConfig value){
				this.config_ = value;
			}
			
		}
		
		
		
		
		public class saveFileLogSetting_args {
			
			///<summary>
			/// 文件配置信息
			///</summary>
			
			private com.vip.vop.vcloud.product.FileLogSetting fileLogSetting_;
			
			public com.vip.vop.vcloud.product.FileLogSetting GetFileLogSetting(){
				return this.fileLogSetting_;
			}
			
			public void SetFileLogSetting(com.vip.vop.vcloud.product.FileLogSetting value){
				this.fileLogSetting_ = value;
			}
			
		}
		
		
		
		
		public class saveHost_args {
			
			///<summary>
			/// 主机信息
			///</summary>
			
			private com.vip.vop.vcloud.product.Host host_;
			
			public com.vip.vop.vcloud.product.Host GetHost(){
				return this.host_;
			}
			
			public void SetHost(com.vip.vop.vcloud.product.Host value){
				this.host_ = value;
			}
			
		}
		
		
		
		
		public class testSftpConnectivity_args {
			
			///<summary>
			/// 主机名
			///</summary>
			
			private string host_;
			
			///<summary>
			/// 端口号
			///</summary>
			
			private int? port_;
			
			///<summary>
			/// 用户名
			///</summary>
			
			private string username_;
			
			///<summary>
			/// 登录密码
			///</summary>
			
			private string password_;
			
			public string GetHost(){
				return this.host_;
			}
			
			public void SetHost(string value){
				this.host_ = value;
			}
			public int? GetPort(){
				return this.port_;
			}
			
			public void SetPort(int? value){
				this.port_ = value;
			}
			public string GetUsername(){
				return this.username_;
			}
			
			public void SetUsername(string value){
				this.username_ = value;
			}
			public string GetPassword(){
				return this.password_;
			}
			
			public void SetPassword(string value){
				this.password_ = value;
			}
			
		}
		
		
		
		
		public class updateProductSku_args {
			
			///<summary>
			/// skuId
			///</summary>
			
			private string skuId_;
			
			///<summary>
			/// 更新的sku的值
			///</summary>
			
			private com.vip.vop.vcloud.product.Sku sku_;
			
			public string GetSkuId(){
				return this.skuId_;
			}
			
			public void SetSkuId(string value){
				this.skuId_ = value;
			}
			public com.vip.vop.vcloud.product.Sku GetSku(){
				return this.sku_;
			}
			
			public void SetSku(com.vip.vop.vcloud.product.Sku value){
				this.sku_ = value;
			}
			
		}
		
		
		
		
		public class updateProductSkuAttr_args {
			
			///<summary>
			/// skuId
			///</summary>
			
			private string skuId_;
			
			///<summary>
			/// 要更新的属性值
			///</summary>
			
			private List<com.vip.vop.vcloud.product.Attribute> attributes_;
			
			public string GetSkuId(){
				return this.skuId_;
			}
			
			public void SetSkuId(string value){
				this.skuId_ = value;
			}
			public List<com.vip.vop.vcloud.product.Attribute> GetAttributes(){
				return this.attributes_;
			}
			
			public void SetAttributes(List<com.vip.vop.vcloud.product.Attribute> value){
				this.attributes_ = value;
			}
			
		}
		
		
		
		
		public class updateProductSkuPrice_args {
			
			///<summary>
			/// 更新的商品价格信息
			///</summary>
			
			private List<com.vip.vop.vcloud.product.SkuPrice> skuPrices_;
			
			public List<com.vip.vop.vcloud.product.SkuPrice> GetSkuPrices(){
				return this.skuPrices_;
			}
			
			public void SetSkuPrices(List<com.vip.vop.vcloud.product.SkuPrice> value){
				this.skuPrices_ = value;
			}
			
		}
		
		
		
		
		public class updateProductSkuStatus_args {
			
			///<summary>
			/// 更新条件
			///</summary>
			
			private com.vip.vop.vcloud.product.ProductSkuStatus criteria_;
			
			///<summary>
			/// 更新值
			///</summary>
			
			private com.vip.vop.vcloud.product.ProductSkuStatus skuStatus_;
			
			public com.vip.vop.vcloud.product.ProductSkuStatus GetCriteria(){
				return this.criteria_;
			}
			
			public void SetCriteria(com.vip.vop.vcloud.product.ProductSkuStatus value){
				this.criteria_ = value;
			}
			public com.vip.vop.vcloud.product.ProductSkuStatus GetSkuStatus(){
				return this.skuStatus_;
			}
			
			public void SetSkuStatus(com.vip.vop.vcloud.product.ProductSkuStatus value){
				this.skuStatus_ = value;
			}
			
		}
		
		
		
		
		public class updateProductSpu_args {
			
			///<summary>
			/// spuId
			///</summary>
			
			private string spuId_;
			
			///<summary>
			/// 更新的spu的值
			///</summary>
			
			private com.vip.vop.vcloud.product.Spu spu_;
			
			public string GetSpuId(){
				return this.spuId_;
			}
			
			public void SetSpuId(string value){
				this.spuId_ = value;
			}
			public com.vip.vop.vcloud.product.Spu GetSpu(){
				return this.spu_;
			}
			
			public void SetSpu(com.vip.vop.vcloud.product.Spu value){
				this.spu_ = value;
			}
			
		}
		
		
		
		
		public class updateProductSpuAttr_args {
			
			///<summary>
			/// spuId
			///</summary>
			
			private string spuId_;
			
			///<summary>
			/// 更新的属性值列表
			///</summary>
			
			private List<com.vip.vop.vcloud.product.Attribute> attributes_;
			
			public string GetSpuId(){
				return this.spuId_;
			}
			
			public void SetSpuId(string value){
				this.spuId_ = value;
			}
			public List<com.vip.vop.vcloud.product.Attribute> GetAttributes(){
				return this.attributes_;
			}
			
			public void SetAttributes(List<com.vip.vop.vcloud.product.Attribute> value){
				this.attributes_ = value;
			}
			
		}
		
		
		
		
		public class updateSftpFileLog_args {
			
			///<summary>
			/// 日记id列表
			///</summary>
			
			private List<string> logIdList_;
			
			///<summary>
			/// 日记类型
			///</summary>
			
			private byte? logType_;
			
			///<summary>
			/// 日记新状态
			///</summary>
			
			private byte? status_;
			
			public List<string> GetLogIdList(){
				return this.logIdList_;
			}
			
			public void SetLogIdList(List<string> value){
				this.logIdList_ = value;
			}
			public byte? GetLogType(){
				return this.logType_;
			}
			
			public void SetLogType(byte? value){
				this.logType_ = value;
			}
			public byte? GetStatus(){
				return this.status_;
			}
			
			public void SetStatus(byte? value){
				this.status_ = value;
			}
			
		}
		
		
		
		
		public class updateSpuImageUrl_args {
			
			///<summary>
			/// 合作伙伴id
			///</summary>
			
			private string partnerId_;
			
			///<summary>
			/// 商品spu号
			///</summary>
			
			private string spu_;
			
			///<summary>
			/// 商品图片相对路径
			/// @sampleValue imgPath large/00FUN01TEST_01_A.jpg
			///</summary>
			
			private string imgPath_;
			
			///<summary>
			/// 商品新url
			///</summary>
			
			private string url_;
			
			public string GetPartnerId(){
				return this.partnerId_;
			}
			
			public void SetPartnerId(string value){
				this.partnerId_ = value;
			}
			public string GetSpu(){
				return this.spu_;
			}
			
			public void SetSpu(string value){
				this.spu_ = value;
			}
			public string GetImgPath(){
				return this.imgPath_;
			}
			
			public void SetImgPath(string value){
				this.imgPath_ = value;
			}
			public string GetUrl(){
				return this.url_;
			}
			
			public void SetUrl(string value){
				this.url_ = value;
			}
			
		}
		
		
		
		
		public class deleteEmailConfig_result {
			
			
		}
		
		
		
		
		public class deleteFileLogSettingByPrimaryKey_result {
			
			
		}
		
		
		
		
		public class deleteHostByPrimaryKey_result {
			
			
		}
		
		
		
		
		public class deleteProductByPartner_result {
			
			
		}
		
		
		
		
		public class healthCheck_result {
			
			///<summary>
			///</summary>
			
			private com.vip.hermes.core.health.CheckResult success_;
			
			public com.vip.hermes.core.health.CheckResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.hermes.core.health.CheckResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class listAllFileLogSettings_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.vop.vcloud.product.FileLogSetting> success_;
			
			public List<com.vip.vop.vcloud.product.FileLogSetting> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.vop.vcloud.product.FileLogSetting> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class listHosts_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.vop.vcloud.product.Host> success_;
			
			public List<com.vip.vop.vcloud.product.Host> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.vop.vcloud.product.Host> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class pushPriceToVdgByIdList_result {
			
			
		}
		
		
		
		
		public class pushProductToVdgBySkuIdList_result {
			
			
		}
		
		
		
		
		public class pushProductToVdgBySpuIdList_result {
			
			
		}
		
		
		
		
		public class saveEmailConfig_result {
			
			
		}
		
		
		
		
		public class saveFileLogSetting_result {
			
			
		}
		
		
		
		
		public class saveHost_result {
			
			
		}
		
		
		
		
		public class testSftpConnectivity_result {
			
			///<summary>
			///</summary>
			
			private List<string> success_;
			
			public List<string> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<string> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class updateProductSku_result {
			
			
		}
		
		
		
		
		public class updateProductSkuAttr_result {
			
			
		}
		
		
		
		
		public class updateProductSkuPrice_result {
			
			
		}
		
		
		
		
		public class updateProductSkuStatus_result {
			
			
		}
		
		
		
		
		public class updateProductSpu_result {
			
			
		}
		
		
		
		
		public class updateProductSpuAttr_result {
			
			
		}
		
		
		
		
		public class updateSftpFileLog_result {
			
			
		}
		
		
		
		
		public class updateSpuImageUrl_result {
			
			
		}
		
		
		
		
		
		public class deleteEmailConfig_argsHelper : TBeanSerializer<deleteEmailConfig_args>
		{
			
			public static deleteEmailConfig_argsHelper OBJ = new deleteEmailConfig_argsHelper();
			
			public static deleteEmailConfig_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(deleteEmailConfig_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetPartnerId(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetEmail(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(deleteEmailConfig_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetPartnerId() != null) {
					
					oprot.WriteFieldBegin("partnerId");
					oprot.WriteString(structs.GetPartnerId());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("partnerId can not be null!");
				}
				
				
				if(structs.GetEmail() != null) {
					
					oprot.WriteFieldBegin("email");
					oprot.WriteString(structs.GetEmail());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("email can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(deleteEmailConfig_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class deleteFileLogSettingByPrimaryKey_argsHelper : TBeanSerializer<deleteFileLogSettingByPrimaryKey_args>
		{
			
			public static deleteFileLogSettingByPrimaryKey_argsHelper OBJ = new deleteFileLogSettingByPrimaryKey_argsHelper();
			
			public static deleteFileLogSettingByPrimaryKey_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(deleteFileLogSettingByPrimaryKey_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					long value;
					value = iprot.ReadI64(); 
					
					structs.SetId(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(deleteFileLogSettingByPrimaryKey_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetId() != null) {
					
					oprot.WriteFieldBegin("id");
					oprot.WriteI64((long)structs.GetId()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("id can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(deleteFileLogSettingByPrimaryKey_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class deleteHostByPrimaryKey_argsHelper : TBeanSerializer<deleteHostByPrimaryKey_args>
		{
			
			public static deleteHostByPrimaryKey_argsHelper OBJ = new deleteHostByPrimaryKey_argsHelper();
			
			public static deleteHostByPrimaryKey_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(deleteHostByPrimaryKey_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					long value;
					value = iprot.ReadI64(); 
					
					structs.SetId(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(deleteHostByPrimaryKey_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetId() != null) {
					
					oprot.WriteFieldBegin("id");
					oprot.WriteI64((long)structs.GetId()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("id can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(deleteHostByPrimaryKey_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class deleteProductByPartner_argsHelper : TBeanSerializer<deleteProductByPartner_args>
		{
			
			public static deleteProductByPartner_argsHelper OBJ = new deleteProductByPartner_argsHelper();
			
			public static deleteProductByPartner_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(deleteProductByPartner_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					long value;
					value = iprot.ReadI64(); 
					
					structs.SetPartnerId(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(deleteProductByPartner_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetPartnerId() != null) {
					
					oprot.WriteFieldBegin("partnerId");
					oprot.WriteI64((long)structs.GetPartnerId()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("partnerId can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(deleteProductByPartner_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class healthCheck_argsHelper : TBeanSerializer<healthCheck_args>
		{
			
			public static healthCheck_argsHelper OBJ = new healthCheck_argsHelper();
			
			public static healthCheck_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(healthCheck_args structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(healthCheck_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(healthCheck_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class listAllFileLogSettings_argsHelper : TBeanSerializer<listAllFileLogSettings_args>
		{
			
			public static listAllFileLogSettings_argsHelper OBJ = new listAllFileLogSettings_argsHelper();
			
			public static listAllFileLogSettings_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(listAllFileLogSettings_args structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(listAllFileLogSettings_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(listAllFileLogSettings_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class listHosts_argsHelper : TBeanSerializer<listHosts_args>
		{
			
			public static listHosts_argsHelper OBJ = new listHosts_argsHelper();
			
			public static listHosts_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(listHosts_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					long value;
					value = iprot.ReadI64(); 
					
					structs.SetPartnerId(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(listHosts_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetPartnerId() != null) {
					
					oprot.WriteFieldBegin("partnerId");
					oprot.WriteI64((long)structs.GetPartnerId()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("partnerId can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(listHosts_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class pushPriceToVdgByIdList_argsHelper : TBeanSerializer<pushPriceToVdgByIdList_args>
		{
			
			public static pushPriceToVdgByIdList_argsHelper OBJ = new pushPriceToVdgByIdList_argsHelper();
			
			public static pushPriceToVdgByIdList_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(pushPriceToVdgByIdList_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<string> value;
					
					value = new List<string>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							string elem0;
							elem0 = iprot.ReadString();
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetIdList(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(pushPriceToVdgByIdList_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetIdList() != null) {
					
					oprot.WriteFieldBegin("idList");
					
					oprot.WriteListBegin();
					foreach(string _item0 in structs.GetIdList()){
						
						oprot.WriteString(_item0);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("idList can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(pushPriceToVdgByIdList_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class pushProductToVdgBySkuIdList_argsHelper : TBeanSerializer<pushProductToVdgBySkuIdList_args>
		{
			
			public static pushProductToVdgBySkuIdList_argsHelper OBJ = new pushProductToVdgBySkuIdList_argsHelper();
			
			public static pushProductToVdgBySkuIdList_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(pushProductToVdgBySkuIdList_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<string> value;
					
					value = new List<string>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							string elem1;
							elem1 = iprot.ReadString();
							
							value.Add(elem1);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetSkuIdList(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(pushProductToVdgBySkuIdList_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSkuIdList() != null) {
					
					oprot.WriteFieldBegin("skuIdList");
					
					oprot.WriteListBegin();
					foreach(string _item0 in structs.GetSkuIdList()){
						
						oprot.WriteString(_item0);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("skuIdList can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(pushProductToVdgBySkuIdList_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class pushProductToVdgBySpuIdList_argsHelper : TBeanSerializer<pushProductToVdgBySpuIdList_args>
		{
			
			public static pushProductToVdgBySpuIdList_argsHelper OBJ = new pushProductToVdgBySpuIdList_argsHelper();
			
			public static pushProductToVdgBySpuIdList_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(pushProductToVdgBySpuIdList_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<string> value;
					
					value = new List<string>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							string elem1;
							elem1 = iprot.ReadString();
							
							value.Add(elem1);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetSpuIdList(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(pushProductToVdgBySpuIdList_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSpuIdList() != null) {
					
					oprot.WriteFieldBegin("spuIdList");
					
					oprot.WriteListBegin();
					foreach(string _item0 in structs.GetSpuIdList()){
						
						oprot.WriteString(_item0);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("spuIdList can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(pushProductToVdgBySpuIdList_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class saveEmailConfig_argsHelper : TBeanSerializer<saveEmailConfig_args>
		{
			
			public static saveEmailConfig_argsHelper OBJ = new saveEmailConfig_argsHelper();
			
			public static saveEmailConfig_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(saveEmailConfig_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.vcloud.product.EmailConfig value;
					
					value = new com.vip.vop.vcloud.product.EmailConfig();
					com.vip.vop.vcloud.product.EmailConfigHelper.getInstance().Read(value, iprot);
					
					structs.SetConfig(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(saveEmailConfig_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetConfig() != null) {
					
					oprot.WriteFieldBegin("config");
					
					com.vip.vop.vcloud.product.EmailConfigHelper.getInstance().Write(structs.GetConfig(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("config can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(saveEmailConfig_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class saveFileLogSetting_argsHelper : TBeanSerializer<saveFileLogSetting_args>
		{
			
			public static saveFileLogSetting_argsHelper OBJ = new saveFileLogSetting_argsHelper();
			
			public static saveFileLogSetting_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(saveFileLogSetting_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.vcloud.product.FileLogSetting value;
					
					value = new com.vip.vop.vcloud.product.FileLogSetting();
					com.vip.vop.vcloud.product.FileLogSettingHelper.getInstance().Read(value, iprot);
					
					structs.SetFileLogSetting(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(saveFileLogSetting_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetFileLogSetting() != null) {
					
					oprot.WriteFieldBegin("fileLogSetting");
					
					com.vip.vop.vcloud.product.FileLogSettingHelper.getInstance().Write(structs.GetFileLogSetting(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("fileLogSetting can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(saveFileLogSetting_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class saveHost_argsHelper : TBeanSerializer<saveHost_args>
		{
			
			public static saveHost_argsHelper OBJ = new saveHost_argsHelper();
			
			public static saveHost_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(saveHost_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.vcloud.product.Host value;
					
					value = new com.vip.vop.vcloud.product.Host();
					com.vip.vop.vcloud.product.HostHelper.getInstance().Read(value, iprot);
					
					structs.SetHost(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(saveHost_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetHost() != null) {
					
					oprot.WriteFieldBegin("host");
					
					com.vip.vop.vcloud.product.HostHelper.getInstance().Write(structs.GetHost(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("host can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(saveHost_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class testSftpConnectivity_argsHelper : TBeanSerializer<testSftpConnectivity_args>
		{
			
			public static testSftpConnectivity_argsHelper OBJ = new testSftpConnectivity_argsHelper();
			
			public static testSftpConnectivity_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(testSftpConnectivity_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetHost(value);
				}
				
				
				
				
				
				if(true){
					
					int value;
					value = iprot.ReadI32(); 
					
					structs.SetPort(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetUsername(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetPassword(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(testSftpConnectivity_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetHost() != null) {
					
					oprot.WriteFieldBegin("host");
					oprot.WriteString(structs.GetHost());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("host can not be null!");
				}
				
				
				if(structs.GetPort() != null) {
					
					oprot.WriteFieldBegin("port");
					oprot.WriteI32((int)structs.GetPort()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("port can not be null!");
				}
				
				
				if(structs.GetUsername() != null) {
					
					oprot.WriteFieldBegin("username");
					oprot.WriteString(structs.GetUsername());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("username can not be null!");
				}
				
				
				if(structs.GetPassword() != null) {
					
					oprot.WriteFieldBegin("password");
					oprot.WriteString(structs.GetPassword());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("password can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(testSftpConnectivity_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class updateProductSku_argsHelper : TBeanSerializer<updateProductSku_args>
		{
			
			public static updateProductSku_argsHelper OBJ = new updateProductSku_argsHelper();
			
			public static updateProductSku_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updateProductSku_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetSkuId(value);
				}
				
				
				
				
				
				if(true){
					
					com.vip.vop.vcloud.product.Sku value;
					
					value = new com.vip.vop.vcloud.product.Sku();
					com.vip.vop.vcloud.product.SkuHelper.getInstance().Read(value, iprot);
					
					structs.SetSku(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updateProductSku_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSkuId() != null) {
					
					oprot.WriteFieldBegin("skuId");
					oprot.WriteString(structs.GetSkuId());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetSku() != null) {
					
					oprot.WriteFieldBegin("sku");
					
					com.vip.vop.vcloud.product.SkuHelper.getInstance().Write(structs.GetSku(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("sku can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(updateProductSku_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class updateProductSkuAttr_argsHelper : TBeanSerializer<updateProductSkuAttr_args>
		{
			
			public static updateProductSkuAttr_argsHelper OBJ = new updateProductSkuAttr_argsHelper();
			
			public static updateProductSkuAttr_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updateProductSkuAttr_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetSkuId(value);
				}
				
				
				
				
				
				if(true){
					
					List<com.vip.vop.vcloud.product.Attribute> value;
					
					value = new List<com.vip.vop.vcloud.product.Attribute>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.vop.vcloud.product.Attribute elem0;
							
							elem0 = new com.vip.vop.vcloud.product.Attribute();
							com.vip.vop.vcloud.product.AttributeHelper.getInstance().Read(elem0, iprot);
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetAttributes(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updateProductSkuAttr_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSkuId() != null) {
					
					oprot.WriteFieldBegin("skuId");
					oprot.WriteString(structs.GetSkuId());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetAttributes() != null) {
					
					oprot.WriteFieldBegin("attributes");
					
					oprot.WriteListBegin();
					foreach(com.vip.vop.vcloud.product.Attribute _item0 in structs.GetAttributes()){
						
						
						com.vip.vop.vcloud.product.AttributeHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("attributes can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(updateProductSkuAttr_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class updateProductSkuPrice_argsHelper : TBeanSerializer<updateProductSkuPrice_args>
		{
			
			public static updateProductSkuPrice_argsHelper OBJ = new updateProductSkuPrice_argsHelper();
			
			public static updateProductSkuPrice_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updateProductSkuPrice_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.vop.vcloud.product.SkuPrice> value;
					
					value = new List<com.vip.vop.vcloud.product.SkuPrice>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.vop.vcloud.product.SkuPrice elem1;
							
							elem1 = new com.vip.vop.vcloud.product.SkuPrice();
							com.vip.vop.vcloud.product.SkuPriceHelper.getInstance().Read(elem1, iprot);
							
							value.Add(elem1);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetSkuPrices(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updateProductSkuPrice_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSkuPrices() != null) {
					
					oprot.WriteFieldBegin("skuPrices");
					
					oprot.WriteListBegin();
					foreach(com.vip.vop.vcloud.product.SkuPrice _item0 in structs.GetSkuPrices()){
						
						
						com.vip.vop.vcloud.product.SkuPriceHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("skuPrices can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(updateProductSkuPrice_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class updateProductSkuStatus_argsHelper : TBeanSerializer<updateProductSkuStatus_args>
		{
			
			public static updateProductSkuStatus_argsHelper OBJ = new updateProductSkuStatus_argsHelper();
			
			public static updateProductSkuStatus_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updateProductSkuStatus_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.vcloud.product.ProductSkuStatus value;
					
					value = new com.vip.vop.vcloud.product.ProductSkuStatus();
					com.vip.vop.vcloud.product.ProductSkuStatusHelper.getInstance().Read(value, iprot);
					
					structs.SetCriteria(value);
				}
				
				
				
				
				
				if(true){
					
					com.vip.vop.vcloud.product.ProductSkuStatus value;
					
					value = new com.vip.vop.vcloud.product.ProductSkuStatus();
					com.vip.vop.vcloud.product.ProductSkuStatusHelper.getInstance().Read(value, iprot);
					
					structs.SetSkuStatus(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updateProductSkuStatus_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetCriteria() != null) {
					
					oprot.WriteFieldBegin("criteria");
					
					com.vip.vop.vcloud.product.ProductSkuStatusHelper.getInstance().Write(structs.GetCriteria(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("criteria can not be null!");
				}
				
				
				if(structs.GetSkuStatus() != null) {
					
					oprot.WriteFieldBegin("skuStatus");
					
					com.vip.vop.vcloud.product.ProductSkuStatusHelper.getInstance().Write(structs.GetSkuStatus(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("skuStatus can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(updateProductSkuStatus_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class updateProductSpu_argsHelper : TBeanSerializer<updateProductSpu_args>
		{
			
			public static updateProductSpu_argsHelper OBJ = new updateProductSpu_argsHelper();
			
			public static updateProductSpu_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updateProductSpu_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetSpuId(value);
				}
				
				
				
				
				
				if(true){
					
					com.vip.vop.vcloud.product.Spu value;
					
					value = new com.vip.vop.vcloud.product.Spu();
					com.vip.vop.vcloud.product.SpuHelper.getInstance().Read(value, iprot);
					
					structs.SetSpu(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updateProductSpu_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSpuId() != null) {
					
					oprot.WriteFieldBegin("spuId");
					oprot.WriteString(structs.GetSpuId());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetSpu() != null) {
					
					oprot.WriteFieldBegin("spu");
					
					com.vip.vop.vcloud.product.SpuHelper.getInstance().Write(structs.GetSpu(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("spu can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(updateProductSpu_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class updateProductSpuAttr_argsHelper : TBeanSerializer<updateProductSpuAttr_args>
		{
			
			public static updateProductSpuAttr_argsHelper OBJ = new updateProductSpuAttr_argsHelper();
			
			public static updateProductSpuAttr_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updateProductSpuAttr_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetSpuId(value);
				}
				
				
				
				
				
				if(true){
					
					List<com.vip.vop.vcloud.product.Attribute> value;
					
					value = new List<com.vip.vop.vcloud.product.Attribute>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.vop.vcloud.product.Attribute elem0;
							
							elem0 = new com.vip.vop.vcloud.product.Attribute();
							com.vip.vop.vcloud.product.AttributeHelper.getInstance().Read(elem0, iprot);
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetAttributes(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updateProductSpuAttr_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSpuId() != null) {
					
					oprot.WriteFieldBegin("spuId");
					oprot.WriteString(structs.GetSpuId());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetAttributes() != null) {
					
					oprot.WriteFieldBegin("attributes");
					
					oprot.WriteListBegin();
					foreach(com.vip.vop.vcloud.product.Attribute _item0 in structs.GetAttributes()){
						
						
						com.vip.vop.vcloud.product.AttributeHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("attributes can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(updateProductSpuAttr_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class updateSftpFileLog_argsHelper : TBeanSerializer<updateSftpFileLog_args>
		{
			
			public static updateSftpFileLog_argsHelper OBJ = new updateSftpFileLog_argsHelper();
			
			public static updateSftpFileLog_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updateSftpFileLog_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<string> value;
					
					value = new List<string>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							string elem1;
							elem1 = iprot.ReadString();
							
							value.Add(elem1);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetLogIdList(value);
				}
				
				
				
				
				
				if(true){
					
					byte? value;
					value = iprot.ReadByte(); 
					
					structs.SetLogType(value);
				}
				
				
				
				
				
				if(true){
					
					byte? value;
					value = iprot.ReadByte(); 
					
					structs.SetStatus(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updateSftpFileLog_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetLogIdList() != null) {
					
					oprot.WriteFieldBegin("logIdList");
					
					oprot.WriteListBegin();
					foreach(string _item0 in structs.GetLogIdList()){
						
						oprot.WriteString(_item0);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetLogType() != null) {
					
					oprot.WriteFieldBegin("logType");
					oprot.WriteByte((byte)structs.GetLogType()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetStatus() != null) {
					
					oprot.WriteFieldBegin("status");
					oprot.WriteByte((byte)structs.GetStatus()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(updateSftpFileLog_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class updateSpuImageUrl_argsHelper : TBeanSerializer<updateSpuImageUrl_args>
		{
			
			public static updateSpuImageUrl_argsHelper OBJ = new updateSpuImageUrl_argsHelper();
			
			public static updateSpuImageUrl_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updateSpuImageUrl_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetPartnerId(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetSpu(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetImgPath(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetUrl(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updateSpuImageUrl_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetPartnerId() != null) {
					
					oprot.WriteFieldBegin("partnerId");
					oprot.WriteString(structs.GetPartnerId());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("partnerId can not be null!");
				}
				
				
				if(structs.GetSpu() != null) {
					
					oprot.WriteFieldBegin("spu");
					oprot.WriteString(structs.GetSpu());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("spu can not be null!");
				}
				
				
				if(structs.GetImgPath() != null) {
					
					oprot.WriteFieldBegin("imgPath");
					oprot.WriteString(structs.GetImgPath());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetUrl() != null) {
					
					oprot.WriteFieldBegin("url");
					oprot.WriteString(structs.GetUrl());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("url can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(updateSpuImageUrl_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class deleteEmailConfig_resultHelper : TBeanSerializer<deleteEmailConfig_result>
		{
			
			public static deleteEmailConfig_resultHelper OBJ = new deleteEmailConfig_resultHelper();
			
			public static deleteEmailConfig_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(deleteEmailConfig_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(deleteEmailConfig_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(deleteEmailConfig_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class deleteFileLogSettingByPrimaryKey_resultHelper : TBeanSerializer<deleteFileLogSettingByPrimaryKey_result>
		{
			
			public static deleteFileLogSettingByPrimaryKey_resultHelper OBJ = new deleteFileLogSettingByPrimaryKey_resultHelper();
			
			public static deleteFileLogSettingByPrimaryKey_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(deleteFileLogSettingByPrimaryKey_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(deleteFileLogSettingByPrimaryKey_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(deleteFileLogSettingByPrimaryKey_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class deleteHostByPrimaryKey_resultHelper : TBeanSerializer<deleteHostByPrimaryKey_result>
		{
			
			public static deleteHostByPrimaryKey_resultHelper OBJ = new deleteHostByPrimaryKey_resultHelper();
			
			public static deleteHostByPrimaryKey_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(deleteHostByPrimaryKey_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(deleteHostByPrimaryKey_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(deleteHostByPrimaryKey_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class deleteProductByPartner_resultHelper : TBeanSerializer<deleteProductByPartner_result>
		{
			
			public static deleteProductByPartner_resultHelper OBJ = new deleteProductByPartner_resultHelper();
			
			public static deleteProductByPartner_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(deleteProductByPartner_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(deleteProductByPartner_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(deleteProductByPartner_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class healthCheck_resultHelper : TBeanSerializer<healthCheck_result>
		{
			
			public static healthCheck_resultHelper OBJ = new healthCheck_resultHelper();
			
			public static healthCheck_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(healthCheck_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.hermes.core.health.CheckResult value;
					
					value = new com.vip.hermes.core.health.CheckResult();
					com.vip.hermes.core.health.CheckResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(healthCheck_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.hermes.core.health.CheckResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(healthCheck_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class listAllFileLogSettings_resultHelper : TBeanSerializer<listAllFileLogSettings_result>
		{
			
			public static listAllFileLogSettings_resultHelper OBJ = new listAllFileLogSettings_resultHelper();
			
			public static listAllFileLogSettings_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(listAllFileLogSettings_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.vop.vcloud.product.FileLogSetting> value;
					
					value = new List<com.vip.vop.vcloud.product.FileLogSetting>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.vop.vcloud.product.FileLogSetting elem0;
							
							elem0 = new com.vip.vop.vcloud.product.FileLogSetting();
							com.vip.vop.vcloud.product.FileLogSettingHelper.getInstance().Read(elem0, iprot);
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(listAllFileLogSettings_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.vop.vcloud.product.FileLogSetting _item0 in structs.GetSuccess()){
						
						
						com.vip.vop.vcloud.product.FileLogSettingHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(listAllFileLogSettings_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class listHosts_resultHelper : TBeanSerializer<listHosts_result>
		{
			
			public static listHosts_resultHelper OBJ = new listHosts_resultHelper();
			
			public static listHosts_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(listHosts_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.vop.vcloud.product.Host> value;
					
					value = new List<com.vip.vop.vcloud.product.Host>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.vop.vcloud.product.Host elem1;
							
							elem1 = new com.vip.vop.vcloud.product.Host();
							com.vip.vop.vcloud.product.HostHelper.getInstance().Read(elem1, iprot);
							
							value.Add(elem1);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(listHosts_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.vop.vcloud.product.Host _item0 in structs.GetSuccess()){
						
						
						com.vip.vop.vcloud.product.HostHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(listHosts_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class pushPriceToVdgByIdList_resultHelper : TBeanSerializer<pushPriceToVdgByIdList_result>
		{
			
			public static pushPriceToVdgByIdList_resultHelper OBJ = new pushPriceToVdgByIdList_resultHelper();
			
			public static pushPriceToVdgByIdList_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(pushPriceToVdgByIdList_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(pushPriceToVdgByIdList_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(pushPriceToVdgByIdList_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class pushProductToVdgBySkuIdList_resultHelper : TBeanSerializer<pushProductToVdgBySkuIdList_result>
		{
			
			public static pushProductToVdgBySkuIdList_resultHelper OBJ = new pushProductToVdgBySkuIdList_resultHelper();
			
			public static pushProductToVdgBySkuIdList_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(pushProductToVdgBySkuIdList_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(pushProductToVdgBySkuIdList_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(pushProductToVdgBySkuIdList_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class pushProductToVdgBySpuIdList_resultHelper : TBeanSerializer<pushProductToVdgBySpuIdList_result>
		{
			
			public static pushProductToVdgBySpuIdList_resultHelper OBJ = new pushProductToVdgBySpuIdList_resultHelper();
			
			public static pushProductToVdgBySpuIdList_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(pushProductToVdgBySpuIdList_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(pushProductToVdgBySpuIdList_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(pushProductToVdgBySpuIdList_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class saveEmailConfig_resultHelper : TBeanSerializer<saveEmailConfig_result>
		{
			
			public static saveEmailConfig_resultHelper OBJ = new saveEmailConfig_resultHelper();
			
			public static saveEmailConfig_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(saveEmailConfig_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(saveEmailConfig_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(saveEmailConfig_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class saveFileLogSetting_resultHelper : TBeanSerializer<saveFileLogSetting_result>
		{
			
			public static saveFileLogSetting_resultHelper OBJ = new saveFileLogSetting_resultHelper();
			
			public static saveFileLogSetting_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(saveFileLogSetting_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(saveFileLogSetting_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(saveFileLogSetting_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class saveHost_resultHelper : TBeanSerializer<saveHost_result>
		{
			
			public static saveHost_resultHelper OBJ = new saveHost_resultHelper();
			
			public static saveHost_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(saveHost_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(saveHost_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(saveHost_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class testSftpConnectivity_resultHelper : TBeanSerializer<testSftpConnectivity_result>
		{
			
			public static testSftpConnectivity_resultHelper OBJ = new testSftpConnectivity_resultHelper();
			
			public static testSftpConnectivity_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(testSftpConnectivity_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<string> value;
					
					value = new List<string>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							string elem1;
							elem1 = iprot.ReadString();
							
							value.Add(elem1);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(testSftpConnectivity_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(string _item0 in structs.GetSuccess()){
						
						oprot.WriteString(_item0);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(testSftpConnectivity_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class updateProductSku_resultHelper : TBeanSerializer<updateProductSku_result>
		{
			
			public static updateProductSku_resultHelper OBJ = new updateProductSku_resultHelper();
			
			public static updateProductSku_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updateProductSku_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updateProductSku_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(updateProductSku_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class updateProductSkuAttr_resultHelper : TBeanSerializer<updateProductSkuAttr_result>
		{
			
			public static updateProductSkuAttr_resultHelper OBJ = new updateProductSkuAttr_resultHelper();
			
			public static updateProductSkuAttr_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updateProductSkuAttr_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updateProductSkuAttr_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(updateProductSkuAttr_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class updateProductSkuPrice_resultHelper : TBeanSerializer<updateProductSkuPrice_result>
		{
			
			public static updateProductSkuPrice_resultHelper OBJ = new updateProductSkuPrice_resultHelper();
			
			public static updateProductSkuPrice_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updateProductSkuPrice_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updateProductSkuPrice_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(updateProductSkuPrice_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class updateProductSkuStatus_resultHelper : TBeanSerializer<updateProductSkuStatus_result>
		{
			
			public static updateProductSkuStatus_resultHelper OBJ = new updateProductSkuStatus_resultHelper();
			
			public static updateProductSkuStatus_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updateProductSkuStatus_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updateProductSkuStatus_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(updateProductSkuStatus_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class updateProductSpu_resultHelper : TBeanSerializer<updateProductSpu_result>
		{
			
			public static updateProductSpu_resultHelper OBJ = new updateProductSpu_resultHelper();
			
			public static updateProductSpu_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updateProductSpu_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updateProductSpu_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(updateProductSpu_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class updateProductSpuAttr_resultHelper : TBeanSerializer<updateProductSpuAttr_result>
		{
			
			public static updateProductSpuAttr_resultHelper OBJ = new updateProductSpuAttr_resultHelper();
			
			public static updateProductSpuAttr_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updateProductSpuAttr_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updateProductSpuAttr_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(updateProductSpuAttr_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class updateSftpFileLog_resultHelper : TBeanSerializer<updateSftpFileLog_result>
		{
			
			public static updateSftpFileLog_resultHelper OBJ = new updateSftpFileLog_resultHelper();
			
			public static updateSftpFileLog_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updateSftpFileLog_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updateSftpFileLog_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(updateSftpFileLog_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class updateSpuImageUrl_resultHelper : TBeanSerializer<updateSpuImageUrl_result>
		{
			
			public static updateSpuImageUrl_resultHelper OBJ = new updateSpuImageUrl_resultHelper();
			
			public static updateSpuImageUrl_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updateSpuImageUrl_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updateSpuImageUrl_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(updateSpuImageUrl_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class ProductAdminServiceClient : OspRestStub , ProductAdminService  {
			
			
			public ProductAdminServiceClient():base("com.vip.vop.vcloud.product.ProductAdminService","1.0.0") {
				
				
			}
			
			
			
			public void deleteEmailConfig(string partnerId_,string email_) {
				
				send_deleteEmailConfig(partnerId_,email_);
				recv_deleteEmailConfig();
				
			}
			
			
			private void send_deleteEmailConfig(string partnerId_,string email_){
				
				InitInvocation("deleteEmailConfig");
				
				deleteEmailConfig_args args = new deleteEmailConfig_args();
				args.SetPartnerId(partnerId_);
				args.SetEmail(email_);
				
				SendBase(args, deleteEmailConfig_argsHelper.getInstance());
			}
			
			
			private void recv_deleteEmailConfig(){
				
				deleteEmailConfig_result result = new deleteEmailConfig_result();
				ReceiveBase(result, deleteEmailConfig_resultHelper.getInstance());
				
				
			}
			
			
			public void deleteFileLogSettingByPrimaryKey(long id_) {
				
				send_deleteFileLogSettingByPrimaryKey(id_);
				recv_deleteFileLogSettingByPrimaryKey();
				
			}
			
			
			private void send_deleteFileLogSettingByPrimaryKey(long id_){
				
				InitInvocation("deleteFileLogSettingByPrimaryKey");
				
				deleteFileLogSettingByPrimaryKey_args args = new deleteFileLogSettingByPrimaryKey_args();
				args.SetId(id_);
				
				SendBase(args, deleteFileLogSettingByPrimaryKey_argsHelper.getInstance());
			}
			
			
			private void recv_deleteFileLogSettingByPrimaryKey(){
				
				deleteFileLogSettingByPrimaryKey_result result = new deleteFileLogSettingByPrimaryKey_result();
				ReceiveBase(result, deleteFileLogSettingByPrimaryKey_resultHelper.getInstance());
				
				
			}
			
			
			public void deleteHostByPrimaryKey(long id_) {
				
				send_deleteHostByPrimaryKey(id_);
				recv_deleteHostByPrimaryKey();
				
			}
			
			
			private void send_deleteHostByPrimaryKey(long id_){
				
				InitInvocation("deleteHostByPrimaryKey");
				
				deleteHostByPrimaryKey_args args = new deleteHostByPrimaryKey_args();
				args.SetId(id_);
				
				SendBase(args, deleteHostByPrimaryKey_argsHelper.getInstance());
			}
			
			
			private void recv_deleteHostByPrimaryKey(){
				
				deleteHostByPrimaryKey_result result = new deleteHostByPrimaryKey_result();
				ReceiveBase(result, deleteHostByPrimaryKey_resultHelper.getInstance());
				
				
			}
			
			
			public void deleteProductByPartner(long partnerId_) {
				
				send_deleteProductByPartner(partnerId_);
				recv_deleteProductByPartner();
				
			}
			
			
			private void send_deleteProductByPartner(long partnerId_){
				
				InitInvocation("deleteProductByPartner");
				
				deleteProductByPartner_args args = new deleteProductByPartner_args();
				args.SetPartnerId(partnerId_);
				
				SendBase(args, deleteProductByPartner_argsHelper.getInstance());
			}
			
			
			private void recv_deleteProductByPartner(){
				
				deleteProductByPartner_result result = new deleteProductByPartner_result();
				ReceiveBase(result, deleteProductByPartner_resultHelper.getInstance());
				
				
			}
			
			
			public com.vip.hermes.core.health.CheckResult healthCheck() {
				
				send_healthCheck();
				return recv_healthCheck(); 
				
			}
			
			
			private void send_healthCheck(){
				
				InitInvocation("healthCheck");
				
				healthCheck_args args = new healthCheck_args();
				
				SendBase(args, healthCheck_argsHelper.getInstance());
			}
			
			
			private com.vip.hermes.core.health.CheckResult recv_healthCheck(){
				
				healthCheck_result result = new healthCheck_result();
				ReceiveBase(result, healthCheck_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<com.vip.vop.vcloud.product.FileLogSetting> listAllFileLogSettings() {
				
				send_listAllFileLogSettings();
				return recv_listAllFileLogSettings(); 
				
			}
			
			
			private void send_listAllFileLogSettings(){
				
				InitInvocation("listAllFileLogSettings");
				
				listAllFileLogSettings_args args = new listAllFileLogSettings_args();
				
				SendBase(args, listAllFileLogSettings_argsHelper.getInstance());
			}
			
			
			private List<com.vip.vop.vcloud.product.FileLogSetting> recv_listAllFileLogSettings(){
				
				listAllFileLogSettings_result result = new listAllFileLogSettings_result();
				ReceiveBase(result, listAllFileLogSettings_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<com.vip.vop.vcloud.product.Host> listHosts(long partnerId_) {
				
				send_listHosts(partnerId_);
				return recv_listHosts(); 
				
			}
			
			
			private void send_listHosts(long partnerId_){
				
				InitInvocation("listHosts");
				
				listHosts_args args = new listHosts_args();
				args.SetPartnerId(partnerId_);
				
				SendBase(args, listHosts_argsHelper.getInstance());
			}
			
			
			private List<com.vip.vop.vcloud.product.Host> recv_listHosts(){
				
				listHosts_result result = new listHosts_result();
				ReceiveBase(result, listHosts_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public void pushPriceToVdgByIdList(List<string> idList_) {
				
				send_pushPriceToVdgByIdList(idList_);
				recv_pushPriceToVdgByIdList();
				
			}
			
			
			private void send_pushPriceToVdgByIdList(List<string> idList_){
				
				InitInvocation("pushPriceToVdgByIdList");
				
				pushPriceToVdgByIdList_args args = new pushPriceToVdgByIdList_args();
				args.SetIdList(idList_);
				
				SendBase(args, pushPriceToVdgByIdList_argsHelper.getInstance());
			}
			
			
			private void recv_pushPriceToVdgByIdList(){
				
				pushPriceToVdgByIdList_result result = new pushPriceToVdgByIdList_result();
				ReceiveBase(result, pushPriceToVdgByIdList_resultHelper.getInstance());
				
				
			}
			
			
			public void pushProductToVdgBySkuIdList(List<string> skuIdList_) {
				
				send_pushProductToVdgBySkuIdList(skuIdList_);
				recv_pushProductToVdgBySkuIdList();
				
			}
			
			
			private void send_pushProductToVdgBySkuIdList(List<string> skuIdList_){
				
				InitInvocation("pushProductToVdgBySkuIdList");
				
				pushProductToVdgBySkuIdList_args args = new pushProductToVdgBySkuIdList_args();
				args.SetSkuIdList(skuIdList_);
				
				SendBase(args, pushProductToVdgBySkuIdList_argsHelper.getInstance());
			}
			
			
			private void recv_pushProductToVdgBySkuIdList(){
				
				pushProductToVdgBySkuIdList_result result = new pushProductToVdgBySkuIdList_result();
				ReceiveBase(result, pushProductToVdgBySkuIdList_resultHelper.getInstance());
				
				
			}
			
			
			public void pushProductToVdgBySpuIdList(List<string> spuIdList_) {
				
				send_pushProductToVdgBySpuIdList(spuIdList_);
				recv_pushProductToVdgBySpuIdList();
				
			}
			
			
			private void send_pushProductToVdgBySpuIdList(List<string> spuIdList_){
				
				InitInvocation("pushProductToVdgBySpuIdList");
				
				pushProductToVdgBySpuIdList_args args = new pushProductToVdgBySpuIdList_args();
				args.SetSpuIdList(spuIdList_);
				
				SendBase(args, pushProductToVdgBySpuIdList_argsHelper.getInstance());
			}
			
			
			private void recv_pushProductToVdgBySpuIdList(){
				
				pushProductToVdgBySpuIdList_result result = new pushProductToVdgBySpuIdList_result();
				ReceiveBase(result, pushProductToVdgBySpuIdList_resultHelper.getInstance());
				
				
			}
			
			
			public void saveEmailConfig(com.vip.vop.vcloud.product.EmailConfig config_) {
				
				send_saveEmailConfig(config_);
				recv_saveEmailConfig();
				
			}
			
			
			private void send_saveEmailConfig(com.vip.vop.vcloud.product.EmailConfig config_){
				
				InitInvocation("saveEmailConfig");
				
				saveEmailConfig_args args = new saveEmailConfig_args();
				args.SetConfig(config_);
				
				SendBase(args, saveEmailConfig_argsHelper.getInstance());
			}
			
			
			private void recv_saveEmailConfig(){
				
				saveEmailConfig_result result = new saveEmailConfig_result();
				ReceiveBase(result, saveEmailConfig_resultHelper.getInstance());
				
				
			}
			
			
			public void saveFileLogSetting(com.vip.vop.vcloud.product.FileLogSetting fileLogSetting_) {
				
				send_saveFileLogSetting(fileLogSetting_);
				recv_saveFileLogSetting();
				
			}
			
			
			private void send_saveFileLogSetting(com.vip.vop.vcloud.product.FileLogSetting fileLogSetting_){
				
				InitInvocation("saveFileLogSetting");
				
				saveFileLogSetting_args args = new saveFileLogSetting_args();
				args.SetFileLogSetting(fileLogSetting_);
				
				SendBase(args, saveFileLogSetting_argsHelper.getInstance());
			}
			
			
			private void recv_saveFileLogSetting(){
				
				saveFileLogSetting_result result = new saveFileLogSetting_result();
				ReceiveBase(result, saveFileLogSetting_resultHelper.getInstance());
				
				
			}
			
			
			public void saveHost(com.vip.vop.vcloud.product.Host host_) {
				
				send_saveHost(host_);
				recv_saveHost();
				
			}
			
			
			private void send_saveHost(com.vip.vop.vcloud.product.Host host_){
				
				InitInvocation("saveHost");
				
				saveHost_args args = new saveHost_args();
				args.SetHost(host_);
				
				SendBase(args, saveHost_argsHelper.getInstance());
			}
			
			
			private void recv_saveHost(){
				
				saveHost_result result = new saveHost_result();
				ReceiveBase(result, saveHost_resultHelper.getInstance());
				
				
			}
			
			
			public List<string> testSftpConnectivity(string host_,int port_,string username_,string password_) {
				
				send_testSftpConnectivity(host_,port_,username_,password_);
				return recv_testSftpConnectivity(); 
				
			}
			
			
			private void send_testSftpConnectivity(string host_,int port_,string username_,string password_){
				
				InitInvocation("testSftpConnectivity");
				
				testSftpConnectivity_args args = new testSftpConnectivity_args();
				args.SetHost(host_);
				args.SetPort(port_);
				args.SetUsername(username_);
				args.SetPassword(password_);
				
				SendBase(args, testSftpConnectivity_argsHelper.getInstance());
			}
			
			
			private List<string> recv_testSftpConnectivity(){
				
				testSftpConnectivity_result result = new testSftpConnectivity_result();
				ReceiveBase(result, testSftpConnectivity_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public void updateProductSku(string skuId_,com.vip.vop.vcloud.product.Sku sku_) {
				
				send_updateProductSku(skuId_,sku_);
				recv_updateProductSku();
				
			}
			
			
			private void send_updateProductSku(string skuId_,com.vip.vop.vcloud.product.Sku sku_){
				
				InitInvocation("updateProductSku");
				
				updateProductSku_args args = new updateProductSku_args();
				args.SetSkuId(skuId_);
				args.SetSku(sku_);
				
				SendBase(args, updateProductSku_argsHelper.getInstance());
			}
			
			
			private void recv_updateProductSku(){
				
				updateProductSku_result result = new updateProductSku_result();
				ReceiveBase(result, updateProductSku_resultHelper.getInstance());
				
				
			}
			
			
			public void updateProductSkuAttr(string skuId_,List<com.vip.vop.vcloud.product.Attribute> attributes_) {
				
				send_updateProductSkuAttr(skuId_,attributes_);
				recv_updateProductSkuAttr();
				
			}
			
			
			private void send_updateProductSkuAttr(string skuId_,List<com.vip.vop.vcloud.product.Attribute> attributes_){
				
				InitInvocation("updateProductSkuAttr");
				
				updateProductSkuAttr_args args = new updateProductSkuAttr_args();
				args.SetSkuId(skuId_);
				args.SetAttributes(attributes_);
				
				SendBase(args, updateProductSkuAttr_argsHelper.getInstance());
			}
			
			
			private void recv_updateProductSkuAttr(){
				
				updateProductSkuAttr_result result = new updateProductSkuAttr_result();
				ReceiveBase(result, updateProductSkuAttr_resultHelper.getInstance());
				
				
			}
			
			
			public void updateProductSkuPrice(List<com.vip.vop.vcloud.product.SkuPrice> skuPrices_) {
				
				send_updateProductSkuPrice(skuPrices_);
				recv_updateProductSkuPrice();
				
			}
			
			
			private void send_updateProductSkuPrice(List<com.vip.vop.vcloud.product.SkuPrice> skuPrices_){
				
				InitInvocation("updateProductSkuPrice");
				
				updateProductSkuPrice_args args = new updateProductSkuPrice_args();
				args.SetSkuPrices(skuPrices_);
				
				SendBase(args, updateProductSkuPrice_argsHelper.getInstance());
			}
			
			
			private void recv_updateProductSkuPrice(){
				
				updateProductSkuPrice_result result = new updateProductSkuPrice_result();
				ReceiveBase(result, updateProductSkuPrice_resultHelper.getInstance());
				
				
			}
			
			
			public void updateProductSkuStatus(com.vip.vop.vcloud.product.ProductSkuStatus criteria_,com.vip.vop.vcloud.product.ProductSkuStatus skuStatus_) {
				
				send_updateProductSkuStatus(criteria_,skuStatus_);
				recv_updateProductSkuStatus();
				
			}
			
			
			private void send_updateProductSkuStatus(com.vip.vop.vcloud.product.ProductSkuStatus criteria_,com.vip.vop.vcloud.product.ProductSkuStatus skuStatus_){
				
				InitInvocation("updateProductSkuStatus");
				
				updateProductSkuStatus_args args = new updateProductSkuStatus_args();
				args.SetCriteria(criteria_);
				args.SetSkuStatus(skuStatus_);
				
				SendBase(args, updateProductSkuStatus_argsHelper.getInstance());
			}
			
			
			private void recv_updateProductSkuStatus(){
				
				updateProductSkuStatus_result result = new updateProductSkuStatus_result();
				ReceiveBase(result, updateProductSkuStatus_resultHelper.getInstance());
				
				
			}
			
			
			public void updateProductSpu(string spuId_,com.vip.vop.vcloud.product.Spu spu_) {
				
				send_updateProductSpu(spuId_,spu_);
				recv_updateProductSpu();
				
			}
			
			
			private void send_updateProductSpu(string spuId_,com.vip.vop.vcloud.product.Spu spu_){
				
				InitInvocation("updateProductSpu");
				
				updateProductSpu_args args = new updateProductSpu_args();
				args.SetSpuId(spuId_);
				args.SetSpu(spu_);
				
				SendBase(args, updateProductSpu_argsHelper.getInstance());
			}
			
			
			private void recv_updateProductSpu(){
				
				updateProductSpu_result result = new updateProductSpu_result();
				ReceiveBase(result, updateProductSpu_resultHelper.getInstance());
				
				
			}
			
			
			public void updateProductSpuAttr(string spuId_,List<com.vip.vop.vcloud.product.Attribute> attributes_) {
				
				send_updateProductSpuAttr(spuId_,attributes_);
				recv_updateProductSpuAttr();
				
			}
			
			
			private void send_updateProductSpuAttr(string spuId_,List<com.vip.vop.vcloud.product.Attribute> attributes_){
				
				InitInvocation("updateProductSpuAttr");
				
				updateProductSpuAttr_args args = new updateProductSpuAttr_args();
				args.SetSpuId(spuId_);
				args.SetAttributes(attributes_);
				
				SendBase(args, updateProductSpuAttr_argsHelper.getInstance());
			}
			
			
			private void recv_updateProductSpuAttr(){
				
				updateProductSpuAttr_result result = new updateProductSpuAttr_result();
				ReceiveBase(result, updateProductSpuAttr_resultHelper.getInstance());
				
				
			}
			
			
			public void updateSftpFileLog(List<string> logIdList_,byte? logType_,byte? status_) {
				
				send_updateSftpFileLog(logIdList_,logType_,status_);
				recv_updateSftpFileLog();
				
			}
			
			
			private void send_updateSftpFileLog(List<string> logIdList_,byte? logType_,byte? status_){
				
				InitInvocation("updateSftpFileLog");
				
				updateSftpFileLog_args args = new updateSftpFileLog_args();
				args.SetLogIdList(logIdList_);
				args.SetLogType(logType_);
				args.SetStatus(status_);
				
				SendBase(args, updateSftpFileLog_argsHelper.getInstance());
			}
			
			
			private void recv_updateSftpFileLog(){
				
				updateSftpFileLog_result result = new updateSftpFileLog_result();
				ReceiveBase(result, updateSftpFileLog_resultHelper.getInstance());
				
				
			}
			
			
			public void updateSpuImageUrl(string partnerId_,string spu_,string imgPath_,string url_) {
				
				send_updateSpuImageUrl(partnerId_,spu_,imgPath_,url_);
				recv_updateSpuImageUrl();
				
			}
			
			
			private void send_updateSpuImageUrl(string partnerId_,string spu_,string imgPath_,string url_){
				
				InitInvocation("updateSpuImageUrl");
				
				updateSpuImageUrl_args args = new updateSpuImageUrl_args();
				args.SetPartnerId(partnerId_);
				args.SetSpu(spu_);
				args.SetImgPath(imgPath_);
				args.SetUrl(url_);
				
				SendBase(args, updateSpuImageUrl_argsHelper.getInstance());
			}
			
			
			private void recv_updateSpuImageUrl(){
				
				updateSpuImageUrl_result result = new updateSpuImageUrl_result();
				ReceiveBase(result, updateSpuImageUrl_resultHelper.getInstance());
				
				
			}
			
			
		}
		
		
	}
	
}