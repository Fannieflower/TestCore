using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace vipapis.productsale{
	
	
	public class ProductSaleServiceHelper {
		
		
		
		public class exportExcel_args {
			
			///<summary>
			/// 导出商品销售记录
			///</summary>
			
			private com.vip.vipapis.productsale.service.ProductSaleInfosParam productSaleInfosParam_;
			
			public com.vip.vipapis.productsale.service.ProductSaleInfosParam GetProductSaleInfosParam(){
				return this.productSaleInfosParam_;
			}
			
			public void SetProductSaleInfosParam(com.vip.vipapis.productsale.service.ProductSaleInfosParam value){
				this.productSaleInfosParam_ = value;
			}
			
		}
		
		
		
		
		public class getProductSaleInfoLogs_args {
			
			///<summary>
			/// 查询操作日志
			///</summary>
			
			private long? productSaleInfoId_;
			
			public long? GetProductSaleInfoId(){
				return this.productSaleInfoId_;
			}
			
			public void SetProductSaleInfoId(long? value){
				this.productSaleInfoId_ = value;
			}
			
		}
		
		
		
		
		public class getProductSaleInfos_args {
			
			///<summary>
			/// 查询商品销售情况
			///</summary>
			
			private com.vip.vipapis.productsale.service.ProductSaleParam productSaleParam_;
			
			public com.vip.vipapis.productsale.service.ProductSaleParam GetProductSaleParam(){
				return this.productSaleParam_;
			}
			
			public void SetProductSaleParam(com.vip.vipapis.productsale.service.ProductSaleParam value){
				this.productSaleParam_ = value;
			}
			
		}
		
		
		
		
		public class getProductSaleInfosByIds_args {
			
			///<summary>
			/// 根据IDs查找销售记录
			///</summary>
			
			private List<long?> ids_;
			
			public List<long?> GetIds(){
				return this.ids_;
			}
			
			public void SetIds(List<long?> value){
				this.ids_ = value;
			}
			
		}
		
		
		
		
		public class getProductSaleInfosByParam_args {
			
			///<summary>
			/// 查询商品销售情况
			///</summary>
			
			private com.vip.vipapis.productsale.service.ProductSaleInfosParam productSaleInfosParam_;
			
			public com.vip.vipapis.productsale.service.ProductSaleInfosParam GetProductSaleInfosParam(){
				return this.productSaleInfosParam_;
			}
			
			public void SetProductSaleInfosParam(com.vip.vipapis.productsale.service.ProductSaleInfosParam value){
				this.productSaleInfosParam_ = value;
			}
			
		}
		
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class updateProductSaleInfos_args {
			
			///<summary>
			/// 更新销售记录
			///</summary>
			
			private List<com.vip.vipapis.productsale.service.ProductSaleInfoModel> productSaleInfoModel_;
			
			public List<com.vip.vipapis.productsale.service.ProductSaleInfoModel> GetProductSaleInfoModel(){
				return this.productSaleInfoModel_;
			}
			
			public void SetProductSaleInfoModel(List<com.vip.vipapis.productsale.service.ProductSaleInfoModel> value){
				this.productSaleInfoModel_ = value;
			}
			
		}
		
		
		
		
		public class exportExcel_result {
			
			///<summary>
			///</summary>
			
			private string success_;
			
			public string GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(string value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getProductSaleInfoLogs_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.vipapis.productsale.service.ProductSaleInfoLog> success_;
			
			public List<com.vip.vipapis.productsale.service.ProductSaleInfoLog> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.vipapis.productsale.service.ProductSaleInfoLog> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getProductSaleInfos_result {
			
			///<summary>
			///</summary>
			
			private com.vip.vipapis.productsale.service.ProductSaleInfosResponse success_;
			
			public com.vip.vipapis.productsale.service.ProductSaleInfosResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.vipapis.productsale.service.ProductSaleInfosResponse value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getProductSaleInfosByIds_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.vipapis.productsale.service.ProductSaleInfoModel> success_;
			
			public List<com.vip.vipapis.productsale.service.ProductSaleInfoModel> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.vipapis.productsale.service.ProductSaleInfoModel> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getProductSaleInfosByParam_result {
			
			///<summary>
			///</summary>
			
			private com.vip.vipapis.productsale.service.ProductSaleInfoModelResponse success_;
			
			public com.vip.vipapis.productsale.service.ProductSaleInfoModelResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.vipapis.productsale.service.ProductSaleInfoModelResponse value){
				this.success_ = value;
			}
			
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
		
		
		
		
		public class updateProductSaleInfos_result {
			
			///<summary>
			///</summary>
			
			private bool? success_;
			
			public bool? GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(bool? value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		
		public class exportExcel_argsHelper : TBeanSerializer<exportExcel_args>
		{
			
			public static exportExcel_argsHelper OBJ = new exportExcel_argsHelper();
			
			public static exportExcel_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(exportExcel_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vipapis.productsale.service.ProductSaleInfosParam value;
					
					value = new com.vip.vipapis.productsale.service.ProductSaleInfosParam();
					com.vip.vipapis.productsale.service.ProductSaleInfosParamHelper.getInstance().Read(value, iprot);
					
					structs.SetProductSaleInfosParam(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(exportExcel_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetProductSaleInfosParam() != null) {
					
					oprot.WriteFieldBegin("productSaleInfosParam");
					
					com.vip.vipapis.productsale.service.ProductSaleInfosParamHelper.getInstance().Write(structs.GetProductSaleInfosParam(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(exportExcel_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getProductSaleInfoLogs_argsHelper : TBeanSerializer<getProductSaleInfoLogs_args>
		{
			
			public static getProductSaleInfoLogs_argsHelper OBJ = new getProductSaleInfoLogs_argsHelper();
			
			public static getProductSaleInfoLogs_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getProductSaleInfoLogs_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetProductSaleInfoId(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getProductSaleInfoLogs_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetProductSaleInfoId() != null) {
					
					oprot.WriteFieldBegin("productSaleInfoId");
					oprot.WriteI64((long)structs.GetProductSaleInfoId()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getProductSaleInfoLogs_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getProductSaleInfos_argsHelper : TBeanSerializer<getProductSaleInfos_args>
		{
			
			public static getProductSaleInfos_argsHelper OBJ = new getProductSaleInfos_argsHelper();
			
			public static getProductSaleInfos_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getProductSaleInfos_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vipapis.productsale.service.ProductSaleParam value;
					
					value = new com.vip.vipapis.productsale.service.ProductSaleParam();
					com.vip.vipapis.productsale.service.ProductSaleParamHelper.getInstance().Read(value, iprot);
					
					structs.SetProductSaleParam(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getProductSaleInfos_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetProductSaleParam() != null) {
					
					oprot.WriteFieldBegin("productSaleParam");
					
					com.vip.vipapis.productsale.service.ProductSaleParamHelper.getInstance().Write(structs.GetProductSaleParam(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getProductSaleInfos_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getProductSaleInfosByIds_argsHelper : TBeanSerializer<getProductSaleInfosByIds_args>
		{
			
			public static getProductSaleInfosByIds_argsHelper OBJ = new getProductSaleInfosByIds_argsHelper();
			
			public static getProductSaleInfosByIds_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getProductSaleInfosByIds_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<long?> value;
					
					value = new List<long?>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							long elem0;
							elem0 = iprot.ReadI64(); 
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetIds(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getProductSaleInfosByIds_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetIds() != null) {
					
					oprot.WriteFieldBegin("ids");
					
					oprot.WriteListBegin();
					foreach(long _item0 in structs.GetIds()){
						
						oprot.WriteI64((long)_item0); 
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getProductSaleInfosByIds_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getProductSaleInfosByParam_argsHelper : TBeanSerializer<getProductSaleInfosByParam_args>
		{
			
			public static getProductSaleInfosByParam_argsHelper OBJ = new getProductSaleInfosByParam_argsHelper();
			
			public static getProductSaleInfosByParam_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getProductSaleInfosByParam_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vipapis.productsale.service.ProductSaleInfosParam value;
					
					value = new com.vip.vipapis.productsale.service.ProductSaleInfosParam();
					com.vip.vipapis.productsale.service.ProductSaleInfosParamHelper.getInstance().Read(value, iprot);
					
					structs.SetProductSaleInfosParam(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getProductSaleInfosByParam_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetProductSaleInfosParam() != null) {
					
					oprot.WriteFieldBegin("productSaleInfosParam");
					
					com.vip.vipapis.productsale.service.ProductSaleInfosParamHelper.getInstance().Write(structs.GetProductSaleInfosParam(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getProductSaleInfosByParam_args bean){
				
				
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
		
		
		
		
		public class updateProductSaleInfos_argsHelper : TBeanSerializer<updateProductSaleInfos_args>
		{
			
			public static updateProductSaleInfos_argsHelper OBJ = new updateProductSaleInfos_argsHelper();
			
			public static updateProductSaleInfos_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updateProductSaleInfos_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.vipapis.productsale.service.ProductSaleInfoModel> value;
					
					value = new List<com.vip.vipapis.productsale.service.ProductSaleInfoModel>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.vipapis.productsale.service.ProductSaleInfoModel elem0;
							
							elem0 = new com.vip.vipapis.productsale.service.ProductSaleInfoModel();
							com.vip.vipapis.productsale.service.ProductSaleInfoModelHelper.getInstance().Read(elem0, iprot);
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetProductSaleInfoModel(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updateProductSaleInfos_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetProductSaleInfoModel() != null) {
					
					oprot.WriteFieldBegin("productSaleInfoModel");
					
					oprot.WriteListBegin();
					foreach(com.vip.vipapis.productsale.service.ProductSaleInfoModel _item0 in structs.GetProductSaleInfoModel()){
						
						
						com.vip.vipapis.productsale.service.ProductSaleInfoModelHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(updateProductSaleInfos_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class exportExcel_resultHelper : TBeanSerializer<exportExcel_result>
		{
			
			public static exportExcel_resultHelper OBJ = new exportExcel_resultHelper();
			
			public static exportExcel_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(exportExcel_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(exportExcel_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteString(structs.GetSuccess());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(exportExcel_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getProductSaleInfoLogs_resultHelper : TBeanSerializer<getProductSaleInfoLogs_result>
		{
			
			public static getProductSaleInfoLogs_resultHelper OBJ = new getProductSaleInfoLogs_resultHelper();
			
			public static getProductSaleInfoLogs_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getProductSaleInfoLogs_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.vipapis.productsale.service.ProductSaleInfoLog> value;
					
					value = new List<com.vip.vipapis.productsale.service.ProductSaleInfoLog>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.vipapis.productsale.service.ProductSaleInfoLog elem0;
							
							elem0 = new com.vip.vipapis.productsale.service.ProductSaleInfoLog();
							com.vip.vipapis.productsale.service.ProductSaleInfoLogHelper.getInstance().Read(elem0, iprot);
							
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
			
			
			public void Write(getProductSaleInfoLogs_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.vipapis.productsale.service.ProductSaleInfoLog _item0 in structs.GetSuccess()){
						
						
						com.vip.vipapis.productsale.service.ProductSaleInfoLogHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getProductSaleInfoLogs_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getProductSaleInfos_resultHelper : TBeanSerializer<getProductSaleInfos_result>
		{
			
			public static getProductSaleInfos_resultHelper OBJ = new getProductSaleInfos_resultHelper();
			
			public static getProductSaleInfos_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getProductSaleInfos_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vipapis.productsale.service.ProductSaleInfosResponse value;
					
					value = new com.vip.vipapis.productsale.service.ProductSaleInfosResponse();
					com.vip.vipapis.productsale.service.ProductSaleInfosResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getProductSaleInfos_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.vipapis.productsale.service.ProductSaleInfosResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getProductSaleInfos_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getProductSaleInfosByIds_resultHelper : TBeanSerializer<getProductSaleInfosByIds_result>
		{
			
			public static getProductSaleInfosByIds_resultHelper OBJ = new getProductSaleInfosByIds_resultHelper();
			
			public static getProductSaleInfosByIds_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getProductSaleInfosByIds_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.vipapis.productsale.service.ProductSaleInfoModel> value;
					
					value = new List<com.vip.vipapis.productsale.service.ProductSaleInfoModel>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.vipapis.productsale.service.ProductSaleInfoModel elem0;
							
							elem0 = new com.vip.vipapis.productsale.service.ProductSaleInfoModel();
							com.vip.vipapis.productsale.service.ProductSaleInfoModelHelper.getInstance().Read(elem0, iprot);
							
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
			
			
			public void Write(getProductSaleInfosByIds_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.vipapis.productsale.service.ProductSaleInfoModel _item0 in structs.GetSuccess()){
						
						
						com.vip.vipapis.productsale.service.ProductSaleInfoModelHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getProductSaleInfosByIds_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getProductSaleInfosByParam_resultHelper : TBeanSerializer<getProductSaleInfosByParam_result>
		{
			
			public static getProductSaleInfosByParam_resultHelper OBJ = new getProductSaleInfosByParam_resultHelper();
			
			public static getProductSaleInfosByParam_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getProductSaleInfosByParam_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vipapis.productsale.service.ProductSaleInfoModelResponse value;
					
					value = new com.vip.vipapis.productsale.service.ProductSaleInfoModelResponse();
					com.vip.vipapis.productsale.service.ProductSaleInfoModelResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getProductSaleInfosByParam_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.vipapis.productsale.service.ProductSaleInfoModelResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getProductSaleInfosByParam_result bean){
				
				
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
		
		
		
		
		public class updateProductSaleInfos_resultHelper : TBeanSerializer<updateProductSaleInfos_result>
		{
			
			public static updateProductSaleInfos_resultHelper OBJ = new updateProductSaleInfos_resultHelper();
			
			public static updateProductSaleInfos_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updateProductSaleInfos_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					bool? value;
					value = iprot.ReadBool();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updateProductSaleInfos_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteBool((bool)structs.GetSuccess());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(updateProductSaleInfos_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class ProductSaleServiceClient : OspRestStub , ProductSaleService  {
			
			
			public ProductSaleServiceClient():base("vipapis.productsale.ProductSaleService","1.0.0") {
				
				
			}
			
			
			
			public string exportExcel(com.vip.vipapis.productsale.service.ProductSaleInfosParam productSaleInfosParam_) {
				
				send_exportExcel(productSaleInfosParam_);
				return recv_exportExcel(); 
				
			}
			
			
			private void send_exportExcel(com.vip.vipapis.productsale.service.ProductSaleInfosParam productSaleInfosParam_){
				
				InitInvocation("exportExcel");
				
				exportExcel_args args = new exportExcel_args();
				args.SetProductSaleInfosParam(productSaleInfosParam_);
				
				SendBase(args, exportExcel_argsHelper.getInstance());
			}
			
			
			private string recv_exportExcel(){
				
				exportExcel_result result = new exportExcel_result();
				ReceiveBase(result, exportExcel_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<com.vip.vipapis.productsale.service.ProductSaleInfoLog> getProductSaleInfoLogs(long? productSaleInfoId_) {
				
				send_getProductSaleInfoLogs(productSaleInfoId_);
				return recv_getProductSaleInfoLogs(); 
				
			}
			
			
			private void send_getProductSaleInfoLogs(long? productSaleInfoId_){
				
				InitInvocation("getProductSaleInfoLogs");
				
				getProductSaleInfoLogs_args args = new getProductSaleInfoLogs_args();
				args.SetProductSaleInfoId(productSaleInfoId_);
				
				SendBase(args, getProductSaleInfoLogs_argsHelper.getInstance());
			}
			
			
			private List<com.vip.vipapis.productsale.service.ProductSaleInfoLog> recv_getProductSaleInfoLogs(){
				
				getProductSaleInfoLogs_result result = new getProductSaleInfoLogs_result();
				ReceiveBase(result, getProductSaleInfoLogs_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.vipapis.productsale.service.ProductSaleInfosResponse getProductSaleInfos(com.vip.vipapis.productsale.service.ProductSaleParam productSaleParam_) {
				
				send_getProductSaleInfos(productSaleParam_);
				return recv_getProductSaleInfos(); 
				
			}
			
			
			private void send_getProductSaleInfos(com.vip.vipapis.productsale.service.ProductSaleParam productSaleParam_){
				
				InitInvocation("getProductSaleInfos");
				
				getProductSaleInfos_args args = new getProductSaleInfos_args();
				args.SetProductSaleParam(productSaleParam_);
				
				SendBase(args, getProductSaleInfos_argsHelper.getInstance());
			}
			
			
			private com.vip.vipapis.productsale.service.ProductSaleInfosResponse recv_getProductSaleInfos(){
				
				getProductSaleInfos_result result = new getProductSaleInfos_result();
				ReceiveBase(result, getProductSaleInfos_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<com.vip.vipapis.productsale.service.ProductSaleInfoModel> getProductSaleInfosByIds(List<long?> ids_) {
				
				send_getProductSaleInfosByIds(ids_);
				return recv_getProductSaleInfosByIds(); 
				
			}
			
			
			private void send_getProductSaleInfosByIds(List<long?> ids_){
				
				InitInvocation("getProductSaleInfosByIds");
				
				getProductSaleInfosByIds_args args = new getProductSaleInfosByIds_args();
				args.SetIds(ids_);
				
				SendBase(args, getProductSaleInfosByIds_argsHelper.getInstance());
			}
			
			
			private List<com.vip.vipapis.productsale.service.ProductSaleInfoModel> recv_getProductSaleInfosByIds(){
				
				getProductSaleInfosByIds_result result = new getProductSaleInfosByIds_result();
				ReceiveBase(result, getProductSaleInfosByIds_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.vipapis.productsale.service.ProductSaleInfoModelResponse getProductSaleInfosByParam(com.vip.vipapis.productsale.service.ProductSaleInfosParam productSaleInfosParam_) {
				
				send_getProductSaleInfosByParam(productSaleInfosParam_);
				return recv_getProductSaleInfosByParam(); 
				
			}
			
			
			private void send_getProductSaleInfosByParam(com.vip.vipapis.productsale.service.ProductSaleInfosParam productSaleInfosParam_){
				
				InitInvocation("getProductSaleInfosByParam");
				
				getProductSaleInfosByParam_args args = new getProductSaleInfosByParam_args();
				args.SetProductSaleInfosParam(productSaleInfosParam_);
				
				SendBase(args, getProductSaleInfosByParam_argsHelper.getInstance());
			}
			
			
			private com.vip.vipapis.productsale.service.ProductSaleInfoModelResponse recv_getProductSaleInfosByParam(){
				
				getProductSaleInfosByParam_result result = new getProductSaleInfosByParam_result();
				ReceiveBase(result, getProductSaleInfosByParam_resultHelper.getInstance());
				
				return result.GetSuccess();
				
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
			
			
			public bool? updateProductSaleInfos(List<com.vip.vipapis.productsale.service.ProductSaleInfoModel> productSaleInfoModel_) {
				
				send_updateProductSaleInfos(productSaleInfoModel_);
				return recv_updateProductSaleInfos(); 
				
			}
			
			
			private void send_updateProductSaleInfos(List<com.vip.vipapis.productsale.service.ProductSaleInfoModel> productSaleInfoModel_){
				
				InitInvocation("updateProductSaleInfos");
				
				updateProductSaleInfos_args args = new updateProductSaleInfos_args();
				args.SetProductSaleInfoModel(productSaleInfoModel_);
				
				SendBase(args, updateProductSaleInfos_argsHelper.getInstance());
			}
			
			
			private bool? recv_updateProductSaleInfos(){
				
				updateProductSaleInfos_result result = new updateProductSaleInfos_result();
				ReceiveBase(result, updateProductSaleInfos_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
		}
		
		
	}
	
}