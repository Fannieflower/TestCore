using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace com.vip.xstore.cc.price{
	
	
	public class InternalPriceServiceHelper {
		
		
		
		public class batchGetPrice_args {
			
			///<summary>
			/// 批量查询商品售价请求
			///</summary>
			
			private com.vip.xstore.cc.price.BatchGetPriceReq req_;
			
			public com.vip.xstore.cc.price.BatchGetPriceReq GetReq(){
				return this.req_;
			}
			
			public void SetReq(com.vip.xstore.cc.price.BatchGetPriceReq value){
				this.req_ = value;
			}
			
		}
		
		
		
		
		public class batchGetProdItemBaseCostPrice_args {
			
			///<summary>
			/// 请求上下文
			///</summary>
			
			private com.vip.xstore.cc.price.ReqContext context_;
			
			///<summary>
			/// 商品列表
			///</summary>
			
			private List<com.vip.xstore.cc.price.ProdItemId> items_;
			
			public com.vip.xstore.cc.price.ReqContext GetContext(){
				return this.context_;
			}
			
			public void SetContext(com.vip.xstore.cc.price.ReqContext value){
				this.context_ = value;
			}
			public List<com.vip.xstore.cc.price.ProdItemId> GetItems(){
				return this.items_;
			}
			
			public void SetItems(List<com.vip.xstore.cc.price.ProdItemId> value){
				this.items_ = value;
			}
			
		}
		
		
		
		
		public class batchGetProdItemHisPrice_args {
			
			///<summary>
			/// 请求上下文
			///</summary>
			
			private com.vip.xstore.cc.price.ReqContext context_;
			
			///<summary>
			/// 公司编码(xstorebuy=VIPSHOP，maxxbuy=VIPMAXX)
			///</summary>
			
			private string companyCode_;
			
			///<summary>
			/// 门店商品列表
			///</summary>
			
			private List<com.vip.xstore.cc.price.StoreProdItemIdentity> storeProdItems_;
			
			///<summary>
			/// 查询时间
			///</summary>
			
			private System.DateTime? queryTime_;
			
			public com.vip.xstore.cc.price.ReqContext GetContext(){
				return this.context_;
			}
			
			public void SetContext(com.vip.xstore.cc.price.ReqContext value){
				this.context_ = value;
			}
			public string GetCompanyCode(){
				return this.companyCode_;
			}
			
			public void SetCompanyCode(string value){
				this.companyCode_ = value;
			}
			public List<com.vip.xstore.cc.price.StoreProdItemIdentity> GetStoreProdItems(){
				return this.storeProdItems_;
			}
			
			public void SetStoreProdItems(List<com.vip.xstore.cc.price.StoreProdItemIdentity> value){
				this.storeProdItems_ = value;
			}
			public System.DateTime? GetQueryTime(){
				return this.queryTime_;
			}
			
			public void SetQueryTime(System.DateTime? value){
				this.queryTime_ = value;
			}
			
		}
		
		
		
		
		public class batchGetProdItemNewestPrice_args {
			
			///<summary>
			/// 请求上下文
			///</summary>
			
			private com.vip.xstore.cc.price.ReqContext context_;
			
			///<summary>
			/// 公司编码(xstorebuy=VIPSHOP，maxxbuy=VIPMAXX)
			///</summary>
			
			private string companyCode_;
			
			///<summary>
			/// 门店商品列表
			///</summary>
			
			private List<com.vip.xstore.cc.price.StoreProdItemIdentity> storeProdItems_;
			
			public com.vip.xstore.cc.price.ReqContext GetContext(){
				return this.context_;
			}
			
			public void SetContext(com.vip.xstore.cc.price.ReqContext value){
				this.context_ = value;
			}
			public string GetCompanyCode(){
				return this.companyCode_;
			}
			
			public void SetCompanyCode(string value){
				this.companyCode_ = value;
			}
			public List<com.vip.xstore.cc.price.StoreProdItemIdentity> GetStoreProdItems(){
				return this.storeProdItems_;
			}
			
			public void SetStoreProdItems(List<com.vip.xstore.cc.price.StoreProdItemIdentity> value){
				this.storeProdItems_ = value;
			}
			
		}
		
		
		
		
		public class batchGetProdItemNewestRetailPrice_args {
			
			///<summary>
			///</summary>
			
			private com.vip.xstore.cc.price.ReqContext context_;
			
			///<summary>
			/// 公司编码(xstorebuy=VIPSHOP，maxxbuy=VIPMAXX)
			///</summary>
			
			private string companyCode_;
			
			///<summary>
			/// 商品条码列表
			///</summary>
			
			private List<string> barcodes_;
			
			public com.vip.xstore.cc.price.ReqContext GetContext(){
				return this.context_;
			}
			
			public void SetContext(com.vip.xstore.cc.price.ReqContext value){
				this.context_ = value;
			}
			public string GetCompanyCode(){
				return this.companyCode_;
			}
			
			public void SetCompanyCode(string value){
				this.companyCode_ = value;
			}
			public List<string> GetBarcodes(){
				return this.barcodes_;
			}
			
			public void SetBarcodes(List<string> value){
				this.barcodes_ = value;
			}
			
		}
		
		
		
		
		public class batchGetProdItemNewestSalePrice_args {
			
			///<summary>
			/// 请求上下文
			///</summary>
			
			private com.vip.xstore.cc.price.ReqContext context_;
			
			///<summary>
			/// 公司编码(xstorebuy=VIPSHOP，maxxbuy=VIPMAXX)
			///</summary>
			
			private string companyCode_;
			
			///<summary>
			/// 门店商品列表
			///</summary>
			
			private List<com.vip.xstore.cc.price.StoreProdItemIdentity> storeProdItems_;
			
			public com.vip.xstore.cc.price.ReqContext GetContext(){
				return this.context_;
			}
			
			public void SetContext(com.vip.xstore.cc.price.ReqContext value){
				this.context_ = value;
			}
			public string GetCompanyCode(){
				return this.companyCode_;
			}
			
			public void SetCompanyCode(string value){
				this.companyCode_ = value;
			}
			public List<com.vip.xstore.cc.price.StoreProdItemIdentity> GetStoreProdItems(){
				return this.storeProdItems_;
			}
			
			public void SetStoreProdItems(List<com.vip.xstore.cc.price.StoreProdItemIdentity> value){
				this.storeProdItems_ = value;
			}
			
		}
		
		
		
		
		public class getPrice_args {
			
			///<summary>
			/// 查询商品售价请求
			///</summary>
			
			private com.vip.xstore.cc.price.GetPriceReq req_;
			
			public com.vip.xstore.cc.price.GetPriceReq GetReq(){
				return this.req_;
			}
			
			public void SetReq(com.vip.xstore.cc.price.GetPriceReq value){
				this.req_ = value;
			}
			
		}
		
		
		
		
		public class getPricingReceipt_args {
			
			///<summary>
			/// 查询定价单请求
			///</summary>
			
			private com.vip.xstore.cc.price.PricingReceiptReq req_;
			
			public com.vip.xstore.cc.price.PricingReceiptReq GetReq(){
				return this.req_;
			}
			
			public void SetReq(com.vip.xstore.cc.price.PricingReceiptReq value){
				this.req_ = value;
			}
			
		}
		
		
		
		
		public class getPricingReceiptItem_args {
			
			///<summary>
			/// 查询定价单明细请求
			///</summary>
			
			private com.vip.xstore.cc.price.PricingReceiptItemReq req_;
			
			public com.vip.xstore.cc.price.PricingReceiptItemReq GetReq(){
				return this.req_;
			}
			
			public void SetReq(com.vip.xstore.cc.price.PricingReceiptItemReq value){
				this.req_ = value;
			}
			
		}
		
		
		
		
		public class getProdItemNewestPrice_args {
			
			///<summary>
			/// 请求上下文
			///</summary>
			
			private com.vip.xstore.cc.price.ReqContext context_;
			
			///<summary>
			/// 公司编码(xstorebuy=VIPSHOP，maxxbuy=VIPMAXX)
			///</summary>
			
			private string companyCode_;
			
			///<summary>
			/// 门店编码
			///</summary>
			
			private string storeCode_;
			
			///<summary>
			/// 商品条码
			///</summary>
			
			private string barcode_;
			
			public com.vip.xstore.cc.price.ReqContext GetContext(){
				return this.context_;
			}
			
			public void SetContext(com.vip.xstore.cc.price.ReqContext value){
				this.context_ = value;
			}
			public string GetCompanyCode(){
				return this.companyCode_;
			}
			
			public void SetCompanyCode(string value){
				this.companyCode_ = value;
			}
			public string GetStoreCode(){
				return this.storeCode_;
			}
			
			public void SetStoreCode(string value){
				this.storeCode_ = value;
			}
			public string GetBarcode(){
				return this.barcode_;
			}
			
			public void SetBarcode(string value){
				this.barcode_ = value;
			}
			
		}
		
		
		
		
		public class getProdItemNewestRetailPrice_args {
			
			///<summary>
			///</summary>
			
			private com.vip.xstore.cc.price.ReqContext context_;
			
			///<summary>
			/// 公司编码(xstorebuy=VIPSHOP，maxxbuy=VIPMAXX)
			///</summary>
			
			private string companyCode_;
			
			///<summary>
			/// 商品条码
			///</summary>
			
			private string barcode_;
			
			public com.vip.xstore.cc.price.ReqContext GetContext(){
				return this.context_;
			}
			
			public void SetContext(com.vip.xstore.cc.price.ReqContext value){
				this.context_ = value;
			}
			public string GetCompanyCode(){
				return this.companyCode_;
			}
			
			public void SetCompanyCode(string value){
				this.companyCode_ = value;
			}
			public string GetBarcode(){
				return this.barcode_;
			}
			
			public void SetBarcode(string value){
				this.barcode_ = value;
			}
			
		}
		
		
		
		
		public class getProdItemNewestSalePrice_args {
			
			///<summary>
			/// 请求上下文
			///</summary>
			
			private com.vip.xstore.cc.price.ReqContext context_;
			
			///<summary>
			/// 公司编码(xstorebuy=VIPSHOP，maxxbuy=VIPMAXX)
			///</summary>
			
			private string companyCode_;
			
			///<summary>
			/// 门店编码
			///</summary>
			
			private string storeCode_;
			
			///<summary>
			/// 商品条码
			///</summary>
			
			private string barcode_;
			
			public com.vip.xstore.cc.price.ReqContext GetContext(){
				return this.context_;
			}
			
			public void SetContext(com.vip.xstore.cc.price.ReqContext value){
				this.context_ = value;
			}
			public string GetCompanyCode(){
				return this.companyCode_;
			}
			
			public void SetCompanyCode(string value){
				this.companyCode_ = value;
			}
			public string GetStoreCode(){
				return this.storeCode_;
			}
			
			public void SetStoreCode(string value){
				this.storeCode_ = value;
			}
			public string GetBarcode(){
				return this.barcode_;
			}
			
			public void SetBarcode(string value){
				this.barcode_ = value;
			}
			
		}
		
		
		
		
		public class getProdItemRecentNTimesSalePrice_args {
			
			///<summary>
			/// 请求上下文
			///</summary>
			
			private com.vip.xstore.cc.price.ReqContext context_;
			
			///<summary>
			/// 公司编码(xstorebuy=VIPSHOP，maxxbuy=VIPMAXX)
			///</summary>
			
			private string companyCode_;
			
			///<summary>
			/// 门店编码
			///</summary>
			
			private string storeCode_;
			
			///<summary>
			/// 商品条码
			///</summary>
			
			private string barcode_;
			
			///<summary>
			/// 次数
			///</summary>
			
			private int? nTimes_;
			
			public com.vip.xstore.cc.price.ReqContext GetContext(){
				return this.context_;
			}
			
			public void SetContext(com.vip.xstore.cc.price.ReqContext value){
				this.context_ = value;
			}
			public string GetCompanyCode(){
				return this.companyCode_;
			}
			
			public void SetCompanyCode(string value){
				this.companyCode_ = value;
			}
			public string GetStoreCode(){
				return this.storeCode_;
			}
			
			public void SetStoreCode(string value){
				this.storeCode_ = value;
			}
			public string GetBarcode(){
				return this.barcode_;
			}
			
			public void SetBarcode(string value){
				this.barcode_ = value;
			}
			public int? GetNTimes(){
				return this.nTimes_;
			}
			
			public void SetNTimes(int? value){
				this.nTimes_ = value;
			}
			
		}
		
		
		
		
		public class getProdItemSettlementPrice_args {
			
			///<summary>
			/// 查询商品结算价
			///</summary>
			
			private com.vip.xstore.cc.price.ProdItemSettlementPriceReq req_;
			
			public com.vip.xstore.cc.price.ProdItemSettlementPriceReq GetReq(){
				return this.req_;
			}
			
			public void SetReq(com.vip.xstore.cc.price.ProdItemSettlementPriceReq value){
				this.req_ = value;
			}
			
		}
		
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class batchGetPrice_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.xstore.cc.price.ProdItemPrice> success_;
			
			public List<com.vip.xstore.cc.price.ProdItemPrice> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.xstore.cc.price.ProdItemPrice> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class batchGetProdItemBaseCostPrice_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.xstore.cc.price.ProdItemBaseCostPrice> success_;
			
			public List<com.vip.xstore.cc.price.ProdItemBaseCostPrice> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.xstore.cc.price.ProdItemBaseCostPrice> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class batchGetProdItemHisPrice_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.xstore.cc.price.StoreProdItemHisPrice> success_;
			
			public List<com.vip.xstore.cc.price.StoreProdItemHisPrice> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.xstore.cc.price.StoreProdItemHisPrice> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class batchGetProdItemNewestPrice_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.xstore.cc.price.StoreProdItemPrice> success_;
			
			public List<com.vip.xstore.cc.price.StoreProdItemPrice> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.xstore.cc.price.StoreProdItemPrice> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class batchGetProdItemNewestRetailPrice_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.xstore.cc.price.ProdItemRetailPrice> success_;
			
			public List<com.vip.xstore.cc.price.ProdItemRetailPrice> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.xstore.cc.price.ProdItemRetailPrice> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class batchGetProdItemNewestSalePrice_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.xstore.cc.price.StoreProdItemSalePrice> success_;
			
			public List<com.vip.xstore.cc.price.StoreProdItemSalePrice> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.xstore.cc.price.StoreProdItemSalePrice> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getPrice_result {
			
			///<summary>
			///</summary>
			
			private com.vip.xstore.cc.price.ProdItemPrice success_;
			
			public com.vip.xstore.cc.price.ProdItemPrice GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.xstore.cc.price.ProdItemPrice value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getPricingReceipt_result {
			
			///<summary>
			///</summary>
			
			private com.vip.xstore.cc.price.PricingReceiptResp success_;
			
			public com.vip.xstore.cc.price.PricingReceiptResp GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.xstore.cc.price.PricingReceiptResp value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getPricingReceiptItem_result {
			
			///<summary>
			///</summary>
			
			private com.vip.xstore.cc.price.PricingReceiptItemResp success_;
			
			public com.vip.xstore.cc.price.PricingReceiptItemResp GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.xstore.cc.price.PricingReceiptItemResp value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getProdItemNewestPrice_result {
			
			///<summary>
			///</summary>
			
			private com.vip.xstore.cc.price.StoreProdItemPrice success_;
			
			public com.vip.xstore.cc.price.StoreProdItemPrice GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.xstore.cc.price.StoreProdItemPrice value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getProdItemNewestRetailPrice_result {
			
			///<summary>
			///</summary>
			
			private com.vip.xstore.cc.price.ProdItemRetailPrice success_;
			
			public com.vip.xstore.cc.price.ProdItemRetailPrice GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.xstore.cc.price.ProdItemRetailPrice value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getProdItemNewestSalePrice_result {
			
			///<summary>
			///</summary>
			
			private com.vip.xstore.cc.price.StoreProdItemSalePrice success_;
			
			public com.vip.xstore.cc.price.StoreProdItemSalePrice GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.xstore.cc.price.StoreProdItemSalePrice value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getProdItemRecentNTimesSalePrice_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.xstore.cc.price.StoreProdItemHisSalePrice> success_;
			
			public List<com.vip.xstore.cc.price.StoreProdItemHisSalePrice> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.xstore.cc.price.StoreProdItemHisSalePrice> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getProdItemSettlementPrice_result {
			
			///<summary>
			///</summary>
			
			private com.vip.xstore.cc.price.ProdItemSettlementPriceResp success_;
			
			public com.vip.xstore.cc.price.ProdItemSettlementPriceResp GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.xstore.cc.price.ProdItemSettlementPriceResp value){
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
		
		
		
		
		
		public class batchGetPrice_argsHelper : TBeanSerializer<batchGetPrice_args>
		{
			
			public static batchGetPrice_argsHelper OBJ = new batchGetPrice_argsHelper();
			
			public static batchGetPrice_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(batchGetPrice_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.xstore.cc.price.BatchGetPriceReq value;
					
					value = new com.vip.xstore.cc.price.BatchGetPriceReq();
					com.vip.xstore.cc.price.BatchGetPriceReqHelper.getInstance().Read(value, iprot);
					
					structs.SetReq(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(batchGetPrice_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetReq() != null) {
					
					oprot.WriteFieldBegin("req");
					
					com.vip.xstore.cc.price.BatchGetPriceReqHelper.getInstance().Write(structs.GetReq(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("req can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(batchGetPrice_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class batchGetProdItemBaseCostPrice_argsHelper : TBeanSerializer<batchGetProdItemBaseCostPrice_args>
		{
			
			public static batchGetProdItemBaseCostPrice_argsHelper OBJ = new batchGetProdItemBaseCostPrice_argsHelper();
			
			public static batchGetProdItemBaseCostPrice_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(batchGetProdItemBaseCostPrice_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.xstore.cc.price.ReqContext value;
					
					value = new com.vip.xstore.cc.price.ReqContext();
					com.vip.xstore.cc.price.ReqContextHelper.getInstance().Read(value, iprot);
					
					structs.SetContext(value);
				}
				
				
				
				
				
				if(true){
					
					List<com.vip.xstore.cc.price.ProdItemId> value;
					
					value = new List<com.vip.xstore.cc.price.ProdItemId>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.xstore.cc.price.ProdItemId elem1;
							
							elem1 = new com.vip.xstore.cc.price.ProdItemId();
							com.vip.xstore.cc.price.ProdItemIdHelper.getInstance().Read(elem1, iprot);
							
							value.Add(elem1);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetItems(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(batchGetProdItemBaseCostPrice_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetContext() != null) {
					
					oprot.WriteFieldBegin("context");
					
					com.vip.xstore.cc.price.ReqContextHelper.getInstance().Write(structs.GetContext(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("context can not be null!");
				}
				
				
				if(structs.GetItems() != null) {
					
					oprot.WriteFieldBegin("items");
					
					oprot.WriteListBegin();
					foreach(com.vip.xstore.cc.price.ProdItemId _item0 in structs.GetItems()){
						
						
						com.vip.xstore.cc.price.ProdItemIdHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(batchGetProdItemBaseCostPrice_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class batchGetProdItemHisPrice_argsHelper : TBeanSerializer<batchGetProdItemHisPrice_args>
		{
			
			public static batchGetProdItemHisPrice_argsHelper OBJ = new batchGetProdItemHisPrice_argsHelper();
			
			public static batchGetProdItemHisPrice_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(batchGetProdItemHisPrice_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.xstore.cc.price.ReqContext value;
					
					value = new com.vip.xstore.cc.price.ReqContext();
					com.vip.xstore.cc.price.ReqContextHelper.getInstance().Read(value, iprot);
					
					structs.SetContext(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetCompanyCode(value);
				}
				
				
				
				
				
				if(true){
					
					List<com.vip.xstore.cc.price.StoreProdItemIdentity> value;
					
					value = new List<com.vip.xstore.cc.price.StoreProdItemIdentity>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.xstore.cc.price.StoreProdItemIdentity elem2;
							
							elem2 = new com.vip.xstore.cc.price.StoreProdItemIdentity();
							com.vip.xstore.cc.price.StoreProdItemIdentityHelper.getInstance().Read(elem2, iprot);
							
							value.Add(elem2);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetStoreProdItems(value);
				}
				
				
				
				
				
				if(true){
					
					System.DateTime? value;
					value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
					
					structs.SetQueryTime(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(batchGetProdItemHisPrice_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetContext() != null) {
					
					oprot.WriteFieldBegin("context");
					
					com.vip.xstore.cc.price.ReqContextHelper.getInstance().Write(structs.GetContext(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("context can not be null!");
				}
				
				
				if(structs.GetCompanyCode() != null) {
					
					oprot.WriteFieldBegin("companyCode");
					oprot.WriteString(structs.GetCompanyCode());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetStoreProdItems() != null) {
					
					oprot.WriteFieldBegin("storeProdItems");
					
					oprot.WriteListBegin();
					foreach(com.vip.xstore.cc.price.StoreProdItemIdentity _item0 in structs.GetStoreProdItems()){
						
						
						com.vip.xstore.cc.price.StoreProdItemIdentityHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("storeProdItems can not be null!");
				}
				
				
				if(structs.GetQueryTime() != null) {
					
					oprot.WriteFieldBegin("queryTime");
					oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetQueryTime())); 
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(batchGetProdItemHisPrice_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class batchGetProdItemNewestPrice_argsHelper : TBeanSerializer<batchGetProdItemNewestPrice_args>
		{
			
			public static batchGetProdItemNewestPrice_argsHelper OBJ = new batchGetProdItemNewestPrice_argsHelper();
			
			public static batchGetProdItemNewestPrice_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(batchGetProdItemNewestPrice_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.xstore.cc.price.ReqContext value;
					
					value = new com.vip.xstore.cc.price.ReqContext();
					com.vip.xstore.cc.price.ReqContextHelper.getInstance().Read(value, iprot);
					
					structs.SetContext(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetCompanyCode(value);
				}
				
				
				
				
				
				if(true){
					
					List<com.vip.xstore.cc.price.StoreProdItemIdentity> value;
					
					value = new List<com.vip.xstore.cc.price.StoreProdItemIdentity>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.xstore.cc.price.StoreProdItemIdentity elem1;
							
							elem1 = new com.vip.xstore.cc.price.StoreProdItemIdentity();
							com.vip.xstore.cc.price.StoreProdItemIdentityHelper.getInstance().Read(elem1, iprot);
							
							value.Add(elem1);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetStoreProdItems(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(batchGetProdItemNewestPrice_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetContext() != null) {
					
					oprot.WriteFieldBegin("context");
					
					com.vip.xstore.cc.price.ReqContextHelper.getInstance().Write(structs.GetContext(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("context can not be null!");
				}
				
				
				if(structs.GetCompanyCode() != null) {
					
					oprot.WriteFieldBegin("companyCode");
					oprot.WriteString(structs.GetCompanyCode());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetStoreProdItems() != null) {
					
					oprot.WriteFieldBegin("storeProdItems");
					
					oprot.WriteListBegin();
					foreach(com.vip.xstore.cc.price.StoreProdItemIdentity _item0 in structs.GetStoreProdItems()){
						
						
						com.vip.xstore.cc.price.StoreProdItemIdentityHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("storeProdItems can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(batchGetProdItemNewestPrice_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class batchGetProdItemNewestRetailPrice_argsHelper : TBeanSerializer<batchGetProdItemNewestRetailPrice_args>
		{
			
			public static batchGetProdItemNewestRetailPrice_argsHelper OBJ = new batchGetProdItemNewestRetailPrice_argsHelper();
			
			public static batchGetProdItemNewestRetailPrice_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(batchGetProdItemNewestRetailPrice_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.xstore.cc.price.ReqContext value;
					
					value = new com.vip.xstore.cc.price.ReqContext();
					com.vip.xstore.cc.price.ReqContextHelper.getInstance().Read(value, iprot);
					
					structs.SetContext(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetCompanyCode(value);
				}
				
				
				
				
				
				if(true){
					
					List<string> value;
					
					value = new List<string>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							string elem2;
							elem2 = iprot.ReadString();
							
							value.Add(elem2);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetBarcodes(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(batchGetProdItemNewestRetailPrice_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetContext() != null) {
					
					oprot.WriteFieldBegin("context");
					
					com.vip.xstore.cc.price.ReqContextHelper.getInstance().Write(structs.GetContext(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("context can not be null!");
				}
				
				
				if(structs.GetCompanyCode() != null) {
					
					oprot.WriteFieldBegin("companyCode");
					oprot.WriteString(structs.GetCompanyCode());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetBarcodes() != null) {
					
					oprot.WriteFieldBegin("barcodes");
					
					oprot.WriteListBegin();
					foreach(string _item0 in structs.GetBarcodes()){
						
						oprot.WriteString(_item0);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(batchGetProdItemNewestRetailPrice_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class batchGetProdItemNewestSalePrice_argsHelper : TBeanSerializer<batchGetProdItemNewestSalePrice_args>
		{
			
			public static batchGetProdItemNewestSalePrice_argsHelper OBJ = new batchGetProdItemNewestSalePrice_argsHelper();
			
			public static batchGetProdItemNewestSalePrice_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(batchGetProdItemNewestSalePrice_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.xstore.cc.price.ReqContext value;
					
					value = new com.vip.xstore.cc.price.ReqContext();
					com.vip.xstore.cc.price.ReqContextHelper.getInstance().Read(value, iprot);
					
					structs.SetContext(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetCompanyCode(value);
				}
				
				
				
				
				
				if(true){
					
					List<com.vip.xstore.cc.price.StoreProdItemIdentity> value;
					
					value = new List<com.vip.xstore.cc.price.StoreProdItemIdentity>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.xstore.cc.price.StoreProdItemIdentity elem2;
							
							elem2 = new com.vip.xstore.cc.price.StoreProdItemIdentity();
							com.vip.xstore.cc.price.StoreProdItemIdentityHelper.getInstance().Read(elem2, iprot);
							
							value.Add(elem2);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetStoreProdItems(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(batchGetProdItemNewestSalePrice_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetContext() != null) {
					
					oprot.WriteFieldBegin("context");
					
					com.vip.xstore.cc.price.ReqContextHelper.getInstance().Write(structs.GetContext(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("context can not be null!");
				}
				
				
				if(structs.GetCompanyCode() != null) {
					
					oprot.WriteFieldBegin("companyCode");
					oprot.WriteString(structs.GetCompanyCode());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetStoreProdItems() != null) {
					
					oprot.WriteFieldBegin("storeProdItems");
					
					oprot.WriteListBegin();
					foreach(com.vip.xstore.cc.price.StoreProdItemIdentity _item0 in structs.GetStoreProdItems()){
						
						
						com.vip.xstore.cc.price.StoreProdItemIdentityHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("storeProdItems can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(batchGetProdItemNewestSalePrice_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getPrice_argsHelper : TBeanSerializer<getPrice_args>
		{
			
			public static getPrice_argsHelper OBJ = new getPrice_argsHelper();
			
			public static getPrice_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getPrice_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.xstore.cc.price.GetPriceReq value;
					
					value = new com.vip.xstore.cc.price.GetPriceReq();
					com.vip.xstore.cc.price.GetPriceReqHelper.getInstance().Read(value, iprot);
					
					structs.SetReq(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getPrice_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetReq() != null) {
					
					oprot.WriteFieldBegin("req");
					
					com.vip.xstore.cc.price.GetPriceReqHelper.getInstance().Write(structs.GetReq(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("req can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getPrice_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getPricingReceipt_argsHelper : TBeanSerializer<getPricingReceipt_args>
		{
			
			public static getPricingReceipt_argsHelper OBJ = new getPricingReceipt_argsHelper();
			
			public static getPricingReceipt_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getPricingReceipt_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.xstore.cc.price.PricingReceiptReq value;
					
					value = new com.vip.xstore.cc.price.PricingReceiptReq();
					com.vip.xstore.cc.price.PricingReceiptReqHelper.getInstance().Read(value, iprot);
					
					structs.SetReq(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getPricingReceipt_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetReq() != null) {
					
					oprot.WriteFieldBegin("req");
					
					com.vip.xstore.cc.price.PricingReceiptReqHelper.getInstance().Write(structs.GetReq(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("req can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getPricingReceipt_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getPricingReceiptItem_argsHelper : TBeanSerializer<getPricingReceiptItem_args>
		{
			
			public static getPricingReceiptItem_argsHelper OBJ = new getPricingReceiptItem_argsHelper();
			
			public static getPricingReceiptItem_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getPricingReceiptItem_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.xstore.cc.price.PricingReceiptItemReq value;
					
					value = new com.vip.xstore.cc.price.PricingReceiptItemReq();
					com.vip.xstore.cc.price.PricingReceiptItemReqHelper.getInstance().Read(value, iprot);
					
					structs.SetReq(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getPricingReceiptItem_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetReq() != null) {
					
					oprot.WriteFieldBegin("req");
					
					com.vip.xstore.cc.price.PricingReceiptItemReqHelper.getInstance().Write(structs.GetReq(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("req can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getPricingReceiptItem_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getProdItemNewestPrice_argsHelper : TBeanSerializer<getProdItemNewestPrice_args>
		{
			
			public static getProdItemNewestPrice_argsHelper OBJ = new getProdItemNewestPrice_argsHelper();
			
			public static getProdItemNewestPrice_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getProdItemNewestPrice_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.xstore.cc.price.ReqContext value;
					
					value = new com.vip.xstore.cc.price.ReqContext();
					com.vip.xstore.cc.price.ReqContextHelper.getInstance().Read(value, iprot);
					
					structs.SetContext(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetCompanyCode(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetStoreCode(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetBarcode(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getProdItemNewestPrice_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetContext() != null) {
					
					oprot.WriteFieldBegin("context");
					
					com.vip.xstore.cc.price.ReqContextHelper.getInstance().Write(structs.GetContext(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("context can not be null!");
				}
				
				
				if(structs.GetCompanyCode() != null) {
					
					oprot.WriteFieldBegin("companyCode");
					oprot.WriteString(structs.GetCompanyCode());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetStoreCode() != null) {
					
					oprot.WriteFieldBegin("storeCode");
					oprot.WriteString(structs.GetStoreCode());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetBarcode() != null) {
					
					oprot.WriteFieldBegin("barcode");
					oprot.WriteString(structs.GetBarcode());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getProdItemNewestPrice_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getProdItemNewestRetailPrice_argsHelper : TBeanSerializer<getProdItemNewestRetailPrice_args>
		{
			
			public static getProdItemNewestRetailPrice_argsHelper OBJ = new getProdItemNewestRetailPrice_argsHelper();
			
			public static getProdItemNewestRetailPrice_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getProdItemNewestRetailPrice_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.xstore.cc.price.ReqContext value;
					
					value = new com.vip.xstore.cc.price.ReqContext();
					com.vip.xstore.cc.price.ReqContextHelper.getInstance().Read(value, iprot);
					
					structs.SetContext(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetCompanyCode(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetBarcode(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getProdItemNewestRetailPrice_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetContext() != null) {
					
					oprot.WriteFieldBegin("context");
					
					com.vip.xstore.cc.price.ReqContextHelper.getInstance().Write(structs.GetContext(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("context can not be null!");
				}
				
				
				if(structs.GetCompanyCode() != null) {
					
					oprot.WriteFieldBegin("companyCode");
					oprot.WriteString(structs.GetCompanyCode());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetBarcode() != null) {
					
					oprot.WriteFieldBegin("barcode");
					oprot.WriteString(structs.GetBarcode());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getProdItemNewestRetailPrice_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getProdItemNewestSalePrice_argsHelper : TBeanSerializer<getProdItemNewestSalePrice_args>
		{
			
			public static getProdItemNewestSalePrice_argsHelper OBJ = new getProdItemNewestSalePrice_argsHelper();
			
			public static getProdItemNewestSalePrice_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getProdItemNewestSalePrice_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.xstore.cc.price.ReqContext value;
					
					value = new com.vip.xstore.cc.price.ReqContext();
					com.vip.xstore.cc.price.ReqContextHelper.getInstance().Read(value, iprot);
					
					structs.SetContext(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetCompanyCode(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetStoreCode(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetBarcode(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getProdItemNewestSalePrice_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetContext() != null) {
					
					oprot.WriteFieldBegin("context");
					
					com.vip.xstore.cc.price.ReqContextHelper.getInstance().Write(structs.GetContext(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("context can not be null!");
				}
				
				
				if(structs.GetCompanyCode() != null) {
					
					oprot.WriteFieldBegin("companyCode");
					oprot.WriteString(structs.GetCompanyCode());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetStoreCode() != null) {
					
					oprot.WriteFieldBegin("storeCode");
					oprot.WriteString(structs.GetStoreCode());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetBarcode() != null) {
					
					oprot.WriteFieldBegin("barcode");
					oprot.WriteString(structs.GetBarcode());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getProdItemNewestSalePrice_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getProdItemRecentNTimesSalePrice_argsHelper : TBeanSerializer<getProdItemRecentNTimesSalePrice_args>
		{
			
			public static getProdItemRecentNTimesSalePrice_argsHelper OBJ = new getProdItemRecentNTimesSalePrice_argsHelper();
			
			public static getProdItemRecentNTimesSalePrice_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getProdItemRecentNTimesSalePrice_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.xstore.cc.price.ReqContext value;
					
					value = new com.vip.xstore.cc.price.ReqContext();
					com.vip.xstore.cc.price.ReqContextHelper.getInstance().Read(value, iprot);
					
					structs.SetContext(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetCompanyCode(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetStoreCode(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetBarcode(value);
				}
				
				
				
				
				
				if(true){
					
					int value;
					value = iprot.ReadI32(); 
					
					structs.SetNTimes(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getProdItemRecentNTimesSalePrice_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetContext() != null) {
					
					oprot.WriteFieldBegin("context");
					
					com.vip.xstore.cc.price.ReqContextHelper.getInstance().Write(structs.GetContext(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("context can not be null!");
				}
				
				
				if(structs.GetCompanyCode() != null) {
					
					oprot.WriteFieldBegin("companyCode");
					oprot.WriteString(structs.GetCompanyCode());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetStoreCode() != null) {
					
					oprot.WriteFieldBegin("storeCode");
					oprot.WriteString(structs.GetStoreCode());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetBarcode() != null) {
					
					oprot.WriteFieldBegin("barcode");
					oprot.WriteString(structs.GetBarcode());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetNTimes() != null) {
					
					oprot.WriteFieldBegin("nTimes");
					oprot.WriteI32((int)structs.GetNTimes()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("nTimes can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getProdItemRecentNTimesSalePrice_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getProdItemSettlementPrice_argsHelper : TBeanSerializer<getProdItemSettlementPrice_args>
		{
			
			public static getProdItemSettlementPrice_argsHelper OBJ = new getProdItemSettlementPrice_argsHelper();
			
			public static getProdItemSettlementPrice_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getProdItemSettlementPrice_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.xstore.cc.price.ProdItemSettlementPriceReq value;
					
					value = new com.vip.xstore.cc.price.ProdItemSettlementPriceReq();
					com.vip.xstore.cc.price.ProdItemSettlementPriceReqHelper.getInstance().Read(value, iprot);
					
					structs.SetReq(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getProdItemSettlementPrice_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetReq() != null) {
					
					oprot.WriteFieldBegin("req");
					
					com.vip.xstore.cc.price.ProdItemSettlementPriceReqHelper.getInstance().Write(structs.GetReq(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("req can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getProdItemSettlementPrice_args bean){
				
				
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
		
		
		
		
		public class batchGetPrice_resultHelper : TBeanSerializer<batchGetPrice_result>
		{
			
			public static batchGetPrice_resultHelper OBJ = new batchGetPrice_resultHelper();
			
			public static batchGetPrice_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(batchGetPrice_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.xstore.cc.price.ProdItemPrice> value;
					
					value = new List<com.vip.xstore.cc.price.ProdItemPrice>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.xstore.cc.price.ProdItemPrice elem0;
							
							elem0 = new com.vip.xstore.cc.price.ProdItemPrice();
							com.vip.xstore.cc.price.ProdItemPriceHelper.getInstance().Read(elem0, iprot);
							
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
			
			
			public void Write(batchGetPrice_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.xstore.cc.price.ProdItemPrice _item0 in structs.GetSuccess()){
						
						
						com.vip.xstore.cc.price.ProdItemPriceHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(batchGetPrice_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class batchGetProdItemBaseCostPrice_resultHelper : TBeanSerializer<batchGetProdItemBaseCostPrice_result>
		{
			
			public static batchGetProdItemBaseCostPrice_resultHelper OBJ = new batchGetProdItemBaseCostPrice_resultHelper();
			
			public static batchGetProdItemBaseCostPrice_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(batchGetProdItemBaseCostPrice_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.xstore.cc.price.ProdItemBaseCostPrice> value;
					
					value = new List<com.vip.xstore.cc.price.ProdItemBaseCostPrice>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.xstore.cc.price.ProdItemBaseCostPrice elem1;
							
							elem1 = new com.vip.xstore.cc.price.ProdItemBaseCostPrice();
							com.vip.xstore.cc.price.ProdItemBaseCostPriceHelper.getInstance().Read(elem1, iprot);
							
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
			
			
			public void Write(batchGetProdItemBaseCostPrice_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.xstore.cc.price.ProdItemBaseCostPrice _item0 in structs.GetSuccess()){
						
						
						com.vip.xstore.cc.price.ProdItemBaseCostPriceHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(batchGetProdItemBaseCostPrice_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class batchGetProdItemHisPrice_resultHelper : TBeanSerializer<batchGetProdItemHisPrice_result>
		{
			
			public static batchGetProdItemHisPrice_resultHelper OBJ = new batchGetProdItemHisPrice_resultHelper();
			
			public static batchGetProdItemHisPrice_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(batchGetProdItemHisPrice_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.xstore.cc.price.StoreProdItemHisPrice> value;
					
					value = new List<com.vip.xstore.cc.price.StoreProdItemHisPrice>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.xstore.cc.price.StoreProdItemHisPrice elem1;
							
							elem1 = new com.vip.xstore.cc.price.StoreProdItemHisPrice();
							com.vip.xstore.cc.price.StoreProdItemHisPriceHelper.getInstance().Read(elem1, iprot);
							
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
			
			
			public void Write(batchGetProdItemHisPrice_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.xstore.cc.price.StoreProdItemHisPrice _item0 in structs.GetSuccess()){
						
						
						com.vip.xstore.cc.price.StoreProdItemHisPriceHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(batchGetProdItemHisPrice_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class batchGetProdItemNewestPrice_resultHelper : TBeanSerializer<batchGetProdItemNewestPrice_result>
		{
			
			public static batchGetProdItemNewestPrice_resultHelper OBJ = new batchGetProdItemNewestPrice_resultHelper();
			
			public static batchGetProdItemNewestPrice_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(batchGetProdItemNewestPrice_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.xstore.cc.price.StoreProdItemPrice> value;
					
					value = new List<com.vip.xstore.cc.price.StoreProdItemPrice>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.xstore.cc.price.StoreProdItemPrice elem1;
							
							elem1 = new com.vip.xstore.cc.price.StoreProdItemPrice();
							com.vip.xstore.cc.price.StoreProdItemPriceHelper.getInstance().Read(elem1, iprot);
							
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
			
			
			public void Write(batchGetProdItemNewestPrice_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.xstore.cc.price.StoreProdItemPrice _item0 in structs.GetSuccess()){
						
						
						com.vip.xstore.cc.price.StoreProdItemPriceHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(batchGetProdItemNewestPrice_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class batchGetProdItemNewestRetailPrice_resultHelper : TBeanSerializer<batchGetProdItemNewestRetailPrice_result>
		{
			
			public static batchGetProdItemNewestRetailPrice_resultHelper OBJ = new batchGetProdItemNewestRetailPrice_resultHelper();
			
			public static batchGetProdItemNewestRetailPrice_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(batchGetProdItemNewestRetailPrice_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.xstore.cc.price.ProdItemRetailPrice> value;
					
					value = new List<com.vip.xstore.cc.price.ProdItemRetailPrice>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.xstore.cc.price.ProdItemRetailPrice elem1;
							
							elem1 = new com.vip.xstore.cc.price.ProdItemRetailPrice();
							com.vip.xstore.cc.price.ProdItemRetailPriceHelper.getInstance().Read(elem1, iprot);
							
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
			
			
			public void Write(batchGetProdItemNewestRetailPrice_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.xstore.cc.price.ProdItemRetailPrice _item0 in structs.GetSuccess()){
						
						
						com.vip.xstore.cc.price.ProdItemRetailPriceHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(batchGetProdItemNewestRetailPrice_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class batchGetProdItemNewestSalePrice_resultHelper : TBeanSerializer<batchGetProdItemNewestSalePrice_result>
		{
			
			public static batchGetProdItemNewestSalePrice_resultHelper OBJ = new batchGetProdItemNewestSalePrice_resultHelper();
			
			public static batchGetProdItemNewestSalePrice_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(batchGetProdItemNewestSalePrice_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.xstore.cc.price.StoreProdItemSalePrice> value;
					
					value = new List<com.vip.xstore.cc.price.StoreProdItemSalePrice>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.xstore.cc.price.StoreProdItemSalePrice elem1;
							
							elem1 = new com.vip.xstore.cc.price.StoreProdItemSalePrice();
							com.vip.xstore.cc.price.StoreProdItemSalePriceHelper.getInstance().Read(elem1, iprot);
							
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
			
			
			public void Write(batchGetProdItemNewestSalePrice_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.xstore.cc.price.StoreProdItemSalePrice _item0 in structs.GetSuccess()){
						
						
						com.vip.xstore.cc.price.StoreProdItemSalePriceHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(batchGetProdItemNewestSalePrice_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getPrice_resultHelper : TBeanSerializer<getPrice_result>
		{
			
			public static getPrice_resultHelper OBJ = new getPrice_resultHelper();
			
			public static getPrice_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getPrice_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.xstore.cc.price.ProdItemPrice value;
					
					value = new com.vip.xstore.cc.price.ProdItemPrice();
					com.vip.xstore.cc.price.ProdItemPriceHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getPrice_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.xstore.cc.price.ProdItemPriceHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getPrice_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getPricingReceipt_resultHelper : TBeanSerializer<getPricingReceipt_result>
		{
			
			public static getPricingReceipt_resultHelper OBJ = new getPricingReceipt_resultHelper();
			
			public static getPricingReceipt_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getPricingReceipt_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.xstore.cc.price.PricingReceiptResp value;
					
					value = new com.vip.xstore.cc.price.PricingReceiptResp();
					com.vip.xstore.cc.price.PricingReceiptRespHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getPricingReceipt_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.xstore.cc.price.PricingReceiptRespHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getPricingReceipt_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getPricingReceiptItem_resultHelper : TBeanSerializer<getPricingReceiptItem_result>
		{
			
			public static getPricingReceiptItem_resultHelper OBJ = new getPricingReceiptItem_resultHelper();
			
			public static getPricingReceiptItem_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getPricingReceiptItem_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.xstore.cc.price.PricingReceiptItemResp value;
					
					value = new com.vip.xstore.cc.price.PricingReceiptItemResp();
					com.vip.xstore.cc.price.PricingReceiptItemRespHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getPricingReceiptItem_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.xstore.cc.price.PricingReceiptItemRespHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getPricingReceiptItem_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getProdItemNewestPrice_resultHelper : TBeanSerializer<getProdItemNewestPrice_result>
		{
			
			public static getProdItemNewestPrice_resultHelper OBJ = new getProdItemNewestPrice_resultHelper();
			
			public static getProdItemNewestPrice_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getProdItemNewestPrice_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.xstore.cc.price.StoreProdItemPrice value;
					
					value = new com.vip.xstore.cc.price.StoreProdItemPrice();
					com.vip.xstore.cc.price.StoreProdItemPriceHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getProdItemNewestPrice_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.xstore.cc.price.StoreProdItemPriceHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getProdItemNewestPrice_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getProdItemNewestRetailPrice_resultHelper : TBeanSerializer<getProdItemNewestRetailPrice_result>
		{
			
			public static getProdItemNewestRetailPrice_resultHelper OBJ = new getProdItemNewestRetailPrice_resultHelper();
			
			public static getProdItemNewestRetailPrice_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getProdItemNewestRetailPrice_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.xstore.cc.price.ProdItemRetailPrice value;
					
					value = new com.vip.xstore.cc.price.ProdItemRetailPrice();
					com.vip.xstore.cc.price.ProdItemRetailPriceHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getProdItemNewestRetailPrice_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.xstore.cc.price.ProdItemRetailPriceHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getProdItemNewestRetailPrice_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getProdItemNewestSalePrice_resultHelper : TBeanSerializer<getProdItemNewestSalePrice_result>
		{
			
			public static getProdItemNewestSalePrice_resultHelper OBJ = new getProdItemNewestSalePrice_resultHelper();
			
			public static getProdItemNewestSalePrice_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getProdItemNewestSalePrice_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.xstore.cc.price.StoreProdItemSalePrice value;
					
					value = new com.vip.xstore.cc.price.StoreProdItemSalePrice();
					com.vip.xstore.cc.price.StoreProdItemSalePriceHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getProdItemNewestSalePrice_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.xstore.cc.price.StoreProdItemSalePriceHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getProdItemNewestSalePrice_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getProdItemRecentNTimesSalePrice_resultHelper : TBeanSerializer<getProdItemRecentNTimesSalePrice_result>
		{
			
			public static getProdItemRecentNTimesSalePrice_resultHelper OBJ = new getProdItemRecentNTimesSalePrice_resultHelper();
			
			public static getProdItemRecentNTimesSalePrice_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getProdItemRecentNTimesSalePrice_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.xstore.cc.price.StoreProdItemHisSalePrice> value;
					
					value = new List<com.vip.xstore.cc.price.StoreProdItemHisSalePrice>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.xstore.cc.price.StoreProdItemHisSalePrice elem0;
							
							elem0 = new com.vip.xstore.cc.price.StoreProdItemHisSalePrice();
							com.vip.xstore.cc.price.StoreProdItemHisSalePriceHelper.getInstance().Read(elem0, iprot);
							
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
			
			
			public void Write(getProdItemRecentNTimesSalePrice_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.xstore.cc.price.StoreProdItemHisSalePrice _item0 in structs.GetSuccess()){
						
						
						com.vip.xstore.cc.price.StoreProdItemHisSalePriceHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getProdItemRecentNTimesSalePrice_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getProdItemSettlementPrice_resultHelper : TBeanSerializer<getProdItemSettlementPrice_result>
		{
			
			public static getProdItemSettlementPrice_resultHelper OBJ = new getProdItemSettlementPrice_resultHelper();
			
			public static getProdItemSettlementPrice_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getProdItemSettlementPrice_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.xstore.cc.price.ProdItemSettlementPriceResp value;
					
					value = new com.vip.xstore.cc.price.ProdItemSettlementPriceResp();
					com.vip.xstore.cc.price.ProdItemSettlementPriceRespHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getProdItemSettlementPrice_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.xstore.cc.price.ProdItemSettlementPriceRespHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getProdItemSettlementPrice_result bean){
				
				
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
		
		
		
		
		public class InternalPriceServiceClient : OspRestStub , InternalPriceService  {
			
			
			public InternalPriceServiceClient():base("com.vip.xstore.cc.price.InternalPriceService","1.0.0") {
				
				
			}
			
			
			
			public List<com.vip.xstore.cc.price.ProdItemPrice> batchGetPrice(com.vip.xstore.cc.price.BatchGetPriceReq req_) {
				
				send_batchGetPrice(req_);
				return recv_batchGetPrice(); 
				
			}
			
			
			private void send_batchGetPrice(com.vip.xstore.cc.price.BatchGetPriceReq req_){
				
				InitInvocation("batchGetPrice");
				
				batchGetPrice_args args = new batchGetPrice_args();
				args.SetReq(req_);
				
				SendBase(args, batchGetPrice_argsHelper.getInstance());
			}
			
			
			private List<com.vip.xstore.cc.price.ProdItemPrice> recv_batchGetPrice(){
				
				batchGetPrice_result result = new batchGetPrice_result();
				ReceiveBase(result, batchGetPrice_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<com.vip.xstore.cc.price.ProdItemBaseCostPrice> batchGetProdItemBaseCostPrice(com.vip.xstore.cc.price.ReqContext context_,List<com.vip.xstore.cc.price.ProdItemId> items_) {
				
				send_batchGetProdItemBaseCostPrice(context_,items_);
				return recv_batchGetProdItemBaseCostPrice(); 
				
			}
			
			
			private void send_batchGetProdItemBaseCostPrice(com.vip.xstore.cc.price.ReqContext context_,List<com.vip.xstore.cc.price.ProdItemId> items_){
				
				InitInvocation("batchGetProdItemBaseCostPrice");
				
				batchGetProdItemBaseCostPrice_args args = new batchGetProdItemBaseCostPrice_args();
				args.SetContext(context_);
				args.SetItems(items_);
				
				SendBase(args, batchGetProdItemBaseCostPrice_argsHelper.getInstance());
			}
			
			
			private List<com.vip.xstore.cc.price.ProdItemBaseCostPrice> recv_batchGetProdItemBaseCostPrice(){
				
				batchGetProdItemBaseCostPrice_result result = new batchGetProdItemBaseCostPrice_result();
				ReceiveBase(result, batchGetProdItemBaseCostPrice_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<com.vip.xstore.cc.price.StoreProdItemHisPrice> batchGetProdItemHisPrice(com.vip.xstore.cc.price.ReqContext context_,string companyCode_,List<com.vip.xstore.cc.price.StoreProdItemIdentity> storeProdItems_,System.DateTime? queryTime_) {
				
				send_batchGetProdItemHisPrice(context_,companyCode_,storeProdItems_,queryTime_);
				return recv_batchGetProdItemHisPrice(); 
				
			}
			
			
			private void send_batchGetProdItemHisPrice(com.vip.xstore.cc.price.ReqContext context_,string companyCode_,List<com.vip.xstore.cc.price.StoreProdItemIdentity> storeProdItems_,System.DateTime? queryTime_){
				
				InitInvocation("batchGetProdItemHisPrice");
				
				batchGetProdItemHisPrice_args args = new batchGetProdItemHisPrice_args();
				args.SetContext(context_);
				args.SetCompanyCode(companyCode_);
				args.SetStoreProdItems(storeProdItems_);
				args.SetQueryTime(queryTime_);
				
				SendBase(args, batchGetProdItemHisPrice_argsHelper.getInstance());
			}
			
			
			private List<com.vip.xstore.cc.price.StoreProdItemHisPrice> recv_batchGetProdItemHisPrice(){
				
				batchGetProdItemHisPrice_result result = new batchGetProdItemHisPrice_result();
				ReceiveBase(result, batchGetProdItemHisPrice_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<com.vip.xstore.cc.price.StoreProdItemPrice> batchGetProdItemNewestPrice(com.vip.xstore.cc.price.ReqContext context_,string companyCode_,List<com.vip.xstore.cc.price.StoreProdItemIdentity> storeProdItems_) {
				
				send_batchGetProdItemNewestPrice(context_,companyCode_,storeProdItems_);
				return recv_batchGetProdItemNewestPrice(); 
				
			}
			
			
			private void send_batchGetProdItemNewestPrice(com.vip.xstore.cc.price.ReqContext context_,string companyCode_,List<com.vip.xstore.cc.price.StoreProdItemIdentity> storeProdItems_){
				
				InitInvocation("batchGetProdItemNewestPrice");
				
				batchGetProdItemNewestPrice_args args = new batchGetProdItemNewestPrice_args();
				args.SetContext(context_);
				args.SetCompanyCode(companyCode_);
				args.SetStoreProdItems(storeProdItems_);
				
				SendBase(args, batchGetProdItemNewestPrice_argsHelper.getInstance());
			}
			
			
			private List<com.vip.xstore.cc.price.StoreProdItemPrice> recv_batchGetProdItemNewestPrice(){
				
				batchGetProdItemNewestPrice_result result = new batchGetProdItemNewestPrice_result();
				ReceiveBase(result, batchGetProdItemNewestPrice_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<com.vip.xstore.cc.price.ProdItemRetailPrice> batchGetProdItemNewestRetailPrice(com.vip.xstore.cc.price.ReqContext context_,string companyCode_,List<string> barcodes_) {
				
				send_batchGetProdItemNewestRetailPrice(context_,companyCode_,barcodes_);
				return recv_batchGetProdItemNewestRetailPrice(); 
				
			}
			
			
			private void send_batchGetProdItemNewestRetailPrice(com.vip.xstore.cc.price.ReqContext context_,string companyCode_,List<string> barcodes_){
				
				InitInvocation("batchGetProdItemNewestRetailPrice");
				
				batchGetProdItemNewestRetailPrice_args args = new batchGetProdItemNewestRetailPrice_args();
				args.SetContext(context_);
				args.SetCompanyCode(companyCode_);
				args.SetBarcodes(barcodes_);
				
				SendBase(args, batchGetProdItemNewestRetailPrice_argsHelper.getInstance());
			}
			
			
			private List<com.vip.xstore.cc.price.ProdItemRetailPrice> recv_batchGetProdItemNewestRetailPrice(){
				
				batchGetProdItemNewestRetailPrice_result result = new batchGetProdItemNewestRetailPrice_result();
				ReceiveBase(result, batchGetProdItemNewestRetailPrice_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<com.vip.xstore.cc.price.StoreProdItemSalePrice> batchGetProdItemNewestSalePrice(com.vip.xstore.cc.price.ReqContext context_,string companyCode_,List<com.vip.xstore.cc.price.StoreProdItemIdentity> storeProdItems_) {
				
				send_batchGetProdItemNewestSalePrice(context_,companyCode_,storeProdItems_);
				return recv_batchGetProdItemNewestSalePrice(); 
				
			}
			
			
			private void send_batchGetProdItemNewestSalePrice(com.vip.xstore.cc.price.ReqContext context_,string companyCode_,List<com.vip.xstore.cc.price.StoreProdItemIdentity> storeProdItems_){
				
				InitInvocation("batchGetProdItemNewestSalePrice");
				
				batchGetProdItemNewestSalePrice_args args = new batchGetProdItemNewestSalePrice_args();
				args.SetContext(context_);
				args.SetCompanyCode(companyCode_);
				args.SetStoreProdItems(storeProdItems_);
				
				SendBase(args, batchGetProdItemNewestSalePrice_argsHelper.getInstance());
			}
			
			
			private List<com.vip.xstore.cc.price.StoreProdItemSalePrice> recv_batchGetProdItemNewestSalePrice(){
				
				batchGetProdItemNewestSalePrice_result result = new batchGetProdItemNewestSalePrice_result();
				ReceiveBase(result, batchGetProdItemNewestSalePrice_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.xstore.cc.price.ProdItemPrice getPrice(com.vip.xstore.cc.price.GetPriceReq req_) {
				
				send_getPrice(req_);
				return recv_getPrice(); 
				
			}
			
			
			private void send_getPrice(com.vip.xstore.cc.price.GetPriceReq req_){
				
				InitInvocation("getPrice");
				
				getPrice_args args = new getPrice_args();
				args.SetReq(req_);
				
				SendBase(args, getPrice_argsHelper.getInstance());
			}
			
			
			private com.vip.xstore.cc.price.ProdItemPrice recv_getPrice(){
				
				getPrice_result result = new getPrice_result();
				ReceiveBase(result, getPrice_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.xstore.cc.price.PricingReceiptResp getPricingReceipt(com.vip.xstore.cc.price.PricingReceiptReq req_) {
				
				send_getPricingReceipt(req_);
				return recv_getPricingReceipt(); 
				
			}
			
			
			private void send_getPricingReceipt(com.vip.xstore.cc.price.PricingReceiptReq req_){
				
				InitInvocation("getPricingReceipt");
				
				getPricingReceipt_args args = new getPricingReceipt_args();
				args.SetReq(req_);
				
				SendBase(args, getPricingReceipt_argsHelper.getInstance());
			}
			
			
			private com.vip.xstore.cc.price.PricingReceiptResp recv_getPricingReceipt(){
				
				getPricingReceipt_result result = new getPricingReceipt_result();
				ReceiveBase(result, getPricingReceipt_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.xstore.cc.price.PricingReceiptItemResp getPricingReceiptItem(com.vip.xstore.cc.price.PricingReceiptItemReq req_) {
				
				send_getPricingReceiptItem(req_);
				return recv_getPricingReceiptItem(); 
				
			}
			
			
			private void send_getPricingReceiptItem(com.vip.xstore.cc.price.PricingReceiptItemReq req_){
				
				InitInvocation("getPricingReceiptItem");
				
				getPricingReceiptItem_args args = new getPricingReceiptItem_args();
				args.SetReq(req_);
				
				SendBase(args, getPricingReceiptItem_argsHelper.getInstance());
			}
			
			
			private com.vip.xstore.cc.price.PricingReceiptItemResp recv_getPricingReceiptItem(){
				
				getPricingReceiptItem_result result = new getPricingReceiptItem_result();
				ReceiveBase(result, getPricingReceiptItem_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.xstore.cc.price.StoreProdItemPrice getProdItemNewestPrice(com.vip.xstore.cc.price.ReqContext context_,string companyCode_,string storeCode_,string barcode_) {
				
				send_getProdItemNewestPrice(context_,companyCode_,storeCode_,barcode_);
				return recv_getProdItemNewestPrice(); 
				
			}
			
			
			private void send_getProdItemNewestPrice(com.vip.xstore.cc.price.ReqContext context_,string companyCode_,string storeCode_,string barcode_){
				
				InitInvocation("getProdItemNewestPrice");
				
				getProdItemNewestPrice_args args = new getProdItemNewestPrice_args();
				args.SetContext(context_);
				args.SetCompanyCode(companyCode_);
				args.SetStoreCode(storeCode_);
				args.SetBarcode(barcode_);
				
				SendBase(args, getProdItemNewestPrice_argsHelper.getInstance());
			}
			
			
			private com.vip.xstore.cc.price.StoreProdItemPrice recv_getProdItemNewestPrice(){
				
				getProdItemNewestPrice_result result = new getProdItemNewestPrice_result();
				ReceiveBase(result, getProdItemNewestPrice_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.xstore.cc.price.ProdItemRetailPrice getProdItemNewestRetailPrice(com.vip.xstore.cc.price.ReqContext context_,string companyCode_,string barcode_) {
				
				send_getProdItemNewestRetailPrice(context_,companyCode_,barcode_);
				return recv_getProdItemNewestRetailPrice(); 
				
			}
			
			
			private void send_getProdItemNewestRetailPrice(com.vip.xstore.cc.price.ReqContext context_,string companyCode_,string barcode_){
				
				InitInvocation("getProdItemNewestRetailPrice");
				
				getProdItemNewestRetailPrice_args args = new getProdItemNewestRetailPrice_args();
				args.SetContext(context_);
				args.SetCompanyCode(companyCode_);
				args.SetBarcode(barcode_);
				
				SendBase(args, getProdItemNewestRetailPrice_argsHelper.getInstance());
			}
			
			
			private com.vip.xstore.cc.price.ProdItemRetailPrice recv_getProdItemNewestRetailPrice(){
				
				getProdItemNewestRetailPrice_result result = new getProdItemNewestRetailPrice_result();
				ReceiveBase(result, getProdItemNewestRetailPrice_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.xstore.cc.price.StoreProdItemSalePrice getProdItemNewestSalePrice(com.vip.xstore.cc.price.ReqContext context_,string companyCode_,string storeCode_,string barcode_) {
				
				send_getProdItemNewestSalePrice(context_,companyCode_,storeCode_,barcode_);
				return recv_getProdItemNewestSalePrice(); 
				
			}
			
			
			private void send_getProdItemNewestSalePrice(com.vip.xstore.cc.price.ReqContext context_,string companyCode_,string storeCode_,string barcode_){
				
				InitInvocation("getProdItemNewestSalePrice");
				
				getProdItemNewestSalePrice_args args = new getProdItemNewestSalePrice_args();
				args.SetContext(context_);
				args.SetCompanyCode(companyCode_);
				args.SetStoreCode(storeCode_);
				args.SetBarcode(barcode_);
				
				SendBase(args, getProdItemNewestSalePrice_argsHelper.getInstance());
			}
			
			
			private com.vip.xstore.cc.price.StoreProdItemSalePrice recv_getProdItemNewestSalePrice(){
				
				getProdItemNewestSalePrice_result result = new getProdItemNewestSalePrice_result();
				ReceiveBase(result, getProdItemNewestSalePrice_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<com.vip.xstore.cc.price.StoreProdItemHisSalePrice> getProdItemRecentNTimesSalePrice(com.vip.xstore.cc.price.ReqContext context_,string companyCode_,string storeCode_,string barcode_,int nTimes_) {
				
				send_getProdItemRecentNTimesSalePrice(context_,companyCode_,storeCode_,barcode_,nTimes_);
				return recv_getProdItemRecentNTimesSalePrice(); 
				
			}
			
			
			private void send_getProdItemRecentNTimesSalePrice(com.vip.xstore.cc.price.ReqContext context_,string companyCode_,string storeCode_,string barcode_,int nTimes_){
				
				InitInvocation("getProdItemRecentNTimesSalePrice");
				
				getProdItemRecentNTimesSalePrice_args args = new getProdItemRecentNTimesSalePrice_args();
				args.SetContext(context_);
				args.SetCompanyCode(companyCode_);
				args.SetStoreCode(storeCode_);
				args.SetBarcode(barcode_);
				args.SetNTimes(nTimes_);
				
				SendBase(args, getProdItemRecentNTimesSalePrice_argsHelper.getInstance());
			}
			
			
			private List<com.vip.xstore.cc.price.StoreProdItemHisSalePrice> recv_getProdItemRecentNTimesSalePrice(){
				
				getProdItemRecentNTimesSalePrice_result result = new getProdItemRecentNTimesSalePrice_result();
				ReceiveBase(result, getProdItemRecentNTimesSalePrice_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.xstore.cc.price.ProdItemSettlementPriceResp getProdItemSettlementPrice(com.vip.xstore.cc.price.ProdItemSettlementPriceReq req_) {
				
				send_getProdItemSettlementPrice(req_);
				return recv_getProdItemSettlementPrice(); 
				
			}
			
			
			private void send_getProdItemSettlementPrice(com.vip.xstore.cc.price.ProdItemSettlementPriceReq req_){
				
				InitInvocation("getProdItemSettlementPrice");
				
				getProdItemSettlementPrice_args args = new getProdItemSettlementPrice_args();
				args.SetReq(req_);
				
				SendBase(args, getProdItemSettlementPrice_argsHelper.getInstance());
			}
			
			
			private com.vip.xstore.cc.price.ProdItemSettlementPriceResp recv_getProdItemSettlementPrice(){
				
				getProdItemSettlementPrice_result result = new getProdItemSettlementPrice_result();
				ReceiveBase(result, getProdItemSettlementPrice_resultHelper.getInstance());
				
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
			
			
		}
		
		
	}
	
}