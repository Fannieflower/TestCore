using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace com.vip.xstore.cc.bulkbuying.service{
	
	
	public class PurchaseOrderServiceHelper {
		
		
		
		public class complementBarcodeOriginOfOuterPurchase_args {
			
			
		}
		
		
		
		
		public class delete_args {
			
			///<summary>
			///</summary>
			
			private List<string> purchaseNo_;
			
			public List<string> GetPurchaseNo(){
				return this.purchaseNo_;
			}
			
			public void SetPurchaseNo(List<string> value){
				this.purchaseNo_ = value;
			}
			
		}
		
		
		
		
		public class doImport_args {
			
			///<summary>
			///</summary>
			
			private com.vip.xstore.cc.bulkbuying.service.PurchaseOrderImportRequest request_;
			
			public com.vip.xstore.cc.bulkbuying.service.PurchaseOrderImportRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(com.vip.xstore.cc.bulkbuying.service.PurchaseOrderImportRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class export_args {
			
			///<summary>
			/// 采购单号id,多个以逗号隔开
			///</summary>
			
			private string purchaseNo_;
			
			///<summary>
			/// 导出类型：1、采购订单+商品明细导出模板（无ERP收货数量），2、采购订单+商品明细导出模板（有ERP收货数量）,3、外采按 “商品条码+残次等级” 导出
			///</summary>
			
			private int? exportType_;
			
			public string GetPurchaseNo(){
				return this.purchaseNo_;
			}
			
			public void SetPurchaseNo(string value){
				this.purchaseNo_ = value;
			}
			public int? GetExportType(){
				return this.exportType_;
			}
			
			public void SetExportType(int? value){
				this.exportType_ = value;
			}
			
		}
		
		
		
		
		public class exportAsync_args {
			
			///<summary>
			/// 采购单号id,多个以逗号隔开
			///</summary>
			
			private string purchaseNo_;
			
			///<summary>
			/// 导出类型：1、采购订单+商品明细导出模板（无ERP收货数量），2、采购订单+商品明细导出模板（有ERP收货数量）3、外采按 “商品条码+残次等级” 导出
			///</summary>
			
			private string exportType_;
			
			public string GetPurchaseNo(){
				return this.purchaseNo_;
			}
			
			public void SetPurchaseNo(string value){
				this.purchaseNo_ = value;
			}
			public string GetExportType(){
				return this.exportType_;
			}
			
			public void SetExportType(string value){
				this.exportType_ = value;
			}
			
		}
		
		
		
		
		public class exportPoHead_args {
			
			///<summary>
			/// 采购单号(多个以逗号隔开)
			///</summary>
			
			private string purchaseNo_;
			
			///<summary>
			/// 若未勾选采购单，则返回查询结果里的全部
			///</summary>
			
			private com.vip.xstore.cc.bulkbuying.service.PurchaseOrderQueryModel purchaseOrderQueryModel_;
			
			public string GetPurchaseNo(){
				return this.purchaseNo_;
			}
			
			public void SetPurchaseNo(string value){
				this.purchaseNo_ = value;
			}
			public com.vip.xstore.cc.bulkbuying.service.PurchaseOrderQueryModel GetPurchaseOrderQueryModel(){
				return this.purchaseOrderQueryModel_;
			}
			
			public void SetPurchaseOrderQueryModel(com.vip.xstore.cc.bulkbuying.service.PurchaseOrderQueryModel value){
				this.purchaseOrderQueryModel_ = value;
			}
			
		}
		
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class queryMyApprovedPo_args {
			
			///<summary>
			///</summary>
			
			private com.vip.xstore.cc.bulkbuying.service.QueryMyApprovedPoReq req_;
			
			public com.vip.xstore.cc.bulkbuying.service.QueryMyApprovedPoReq GetReq(){
				return this.req_;
			}
			
			public void SetReq(com.vip.xstore.cc.bulkbuying.service.QueryMyApprovedPoReq value){
				this.req_ = value;
			}
			
		}
		
		
		
		
		public class select_args {
			
			///<summary>
			///</summary>
			
			private string purchaseNo_;
			
			public string GetPurchaseNo(){
				return this.purchaseNo_;
			}
			
			public void SetPurchaseNo(string value){
				this.purchaseNo_ = value;
			}
			
		}
		
		
		
		
		public class selectAll_args {
			
			///<summary>
			///</summary>
			
			private com.vip.xstore.cc.bulkbuying.service.PurchaseOrderSelectAllReq selectAllReq_;
			
			public com.vip.xstore.cc.bulkbuying.service.PurchaseOrderSelectAllReq GetSelectAllReq(){
				return this.selectAllReq_;
			}
			
			public void SetSelectAllReq(com.vip.xstore.cc.bulkbuying.service.PurchaseOrderSelectAllReq value){
				this.selectAllReq_ = value;
			}
			
		}
		
		
		
		
		public class selectPage_args {
			
			///<summary>
			///</summary>
			
			private com.vip.xstore.cc.bulkbuying.service.PurchaseOrderQueryModel purchaseOrderQueryModel_;
			
			public com.vip.xstore.cc.bulkbuying.service.PurchaseOrderQueryModel GetPurchaseOrderQueryModel(){
				return this.purchaseOrderQueryModel_;
			}
			
			public void SetPurchaseOrderQueryModel(com.vip.xstore.cc.bulkbuying.service.PurchaseOrderQueryModel value){
				this.purchaseOrderQueryModel_ = value;
			}
			
		}
		
		
		
		
		public class statPoByGroup_args {
			
			///<summary>
			/// 采购明细统计请求体
			///</summary>
			
			private com.vip.xstore.cc.bulkbuying.service.StatPoCommonReq req_;
			
			public com.vip.xstore.cc.bulkbuying.service.StatPoCommonReq GetReq(){
				return this.req_;
			}
			
			public void SetReq(com.vip.xstore.cc.bulkbuying.service.StatPoCommonReq value){
				this.req_ = value;
			}
			
		}
		
		
		
		
		public class update_args {
			
			///<summary>
			///</summary>
			
			private com.vip.xstore.cc.bulkbuying.service.PurchaseOrderUpdateRequest request_;
			
			public com.vip.xstore.cc.bulkbuying.service.PurchaseOrderUpdateRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(com.vip.xstore.cc.bulkbuying.service.PurchaseOrderUpdateRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class updatePoDistributableGoodsTime_args {
			
			///<summary>
			/// 采购单号
			///</summary>
			
			private string purchaseNo_;
			
			///<summary>
			/// 采购单号
			///</summary>
			
			private System.DateTime? distributableGoodsTime_;
			
			public string GetPurchaseNo(){
				return this.purchaseNo_;
			}
			
			public void SetPurchaseNo(string value){
				this.purchaseNo_ = value;
			}
			public System.DateTime? GetDistributableGoodsTime(){
				return this.distributableGoodsTime_;
			}
			
			public void SetDistributableGoodsTime(System.DateTime? value){
				this.distributableGoodsTime_ = value;
			}
			
		}
		
		
		
		
		public class complementBarcodeOriginOfOuterPurchase_result {
			
			
		}
		
		
		
		
		public class delete_result {
			
			///<summary>
			///</summary>
			
			private int? success_;
			
			public int? GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(int? value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class doImport_result {
			
			///<summary>
			///</summary>
			
			private com.vip.xstore.cc.bulkbuying.service.PurchaseOrderImportResponse success_;
			
			public com.vip.xstore.cc.bulkbuying.service.PurchaseOrderImportResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.xstore.cc.bulkbuying.service.PurchaseOrderImportResponse value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class export_result {
			
			///<summary>
			///</summary>
			
			private com.vip.xstore.cc.bulkbuying.service.PurchaseOrderResult success_;
			
			public com.vip.xstore.cc.bulkbuying.service.PurchaseOrderResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.xstore.cc.bulkbuying.service.PurchaseOrderResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class exportAsync_result {
			
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
		
		
		
		
		public class exportPoHead_result {
			
			///<summary>
			///</summary>
			
			private com.vip.xstore.cc.bulkbuying.service.PurchaseOrderResult success_;
			
			public com.vip.xstore.cc.bulkbuying.service.PurchaseOrderResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.xstore.cc.bulkbuying.service.PurchaseOrderResult value){
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
		
		
		
		
		public class queryMyApprovedPo_result {
			
			///<summary>
			///</summary>
			
			private com.vip.xstore.cc.bulkbuying.service.PurchaseOrderModelResult success_;
			
			public com.vip.xstore.cc.bulkbuying.service.PurchaseOrderModelResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.xstore.cc.bulkbuying.service.PurchaseOrderModelResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class select_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.xstore.cc.bulkbuying.service.PurchaseOrderModel> success_;
			
			public List<com.vip.xstore.cc.bulkbuying.service.PurchaseOrderModel> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.xstore.cc.bulkbuying.service.PurchaseOrderModel> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class selectAll_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.xstore.cc.bulkbuying.service.PurchaseOrderModel> success_;
			
			public List<com.vip.xstore.cc.bulkbuying.service.PurchaseOrderModel> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.xstore.cc.bulkbuying.service.PurchaseOrderModel> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class selectPage_result {
			
			///<summary>
			///</summary>
			
			private com.vip.xstore.cc.bulkbuying.service.PurchaseOrderModelResult success_;
			
			public com.vip.xstore.cc.bulkbuying.service.PurchaseOrderModelResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.xstore.cc.bulkbuying.service.PurchaseOrderModelResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class statPoByGroup_result {
			
			///<summary>
			///</summary>
			
			private com.vip.xstore.cc.bulkbuying.service.StatPoByGroupResp success_;
			
			public com.vip.xstore.cc.bulkbuying.service.StatPoByGroupResp GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.xstore.cc.bulkbuying.service.StatPoByGroupResp value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class update_result {
			
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
		
		
		
		
		public class updatePoDistributableGoodsTime_result {
			
			
		}
		
		
		
		
		
		public class complementBarcodeOriginOfOuterPurchase_argsHelper : TBeanSerializer<complementBarcodeOriginOfOuterPurchase_args>
		{
			
			public static complementBarcodeOriginOfOuterPurchase_argsHelper OBJ = new complementBarcodeOriginOfOuterPurchase_argsHelper();
			
			public static complementBarcodeOriginOfOuterPurchase_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(complementBarcodeOriginOfOuterPurchase_args structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(complementBarcodeOriginOfOuterPurchase_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(complementBarcodeOriginOfOuterPurchase_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class delete_argsHelper : TBeanSerializer<delete_args>
		{
			
			public static delete_argsHelper OBJ = new delete_argsHelper();
			
			public static delete_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(delete_args structs, Protocol iprot){
				
				
				
				
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
					
					structs.SetPurchaseNo(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(delete_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetPurchaseNo() != null) {
					
					oprot.WriteFieldBegin("purchaseNo");
					
					oprot.WriteListBegin();
					foreach(string _item0 in structs.GetPurchaseNo()){
						
						oprot.WriteString(_item0);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(delete_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class doImport_argsHelper : TBeanSerializer<doImport_args>
		{
			
			public static doImport_argsHelper OBJ = new doImport_argsHelper();
			
			public static doImport_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(doImport_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.xstore.cc.bulkbuying.service.PurchaseOrderImportRequest value;
					
					value = new com.vip.xstore.cc.bulkbuying.service.PurchaseOrderImportRequest();
					com.vip.xstore.cc.bulkbuying.service.PurchaseOrderImportRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(doImport_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					com.vip.xstore.cc.bulkbuying.service.PurchaseOrderImportRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("request can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(doImport_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class export_argsHelper : TBeanSerializer<export_args>
		{
			
			public static export_argsHelper OBJ = new export_argsHelper();
			
			public static export_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(export_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetPurchaseNo(value);
				}
				
				
				
				
				
				if(true){
					
					int value;
					value = iprot.ReadI32(); 
					
					structs.SetExportType(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(export_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetPurchaseNo() != null) {
					
					oprot.WriteFieldBegin("purchaseNo");
					oprot.WriteString(structs.GetPurchaseNo());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("purchaseNo can not be null!");
				}
				
				
				if(structs.GetExportType() != null) {
					
					oprot.WriteFieldBegin("exportType");
					oprot.WriteI32((int)structs.GetExportType()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("exportType can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(export_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class exportAsync_argsHelper : TBeanSerializer<exportAsync_args>
		{
			
			public static exportAsync_argsHelper OBJ = new exportAsync_argsHelper();
			
			public static exportAsync_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(exportAsync_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetPurchaseNo(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetExportType(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(exportAsync_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetPurchaseNo() != null) {
					
					oprot.WriteFieldBegin("purchaseNo");
					oprot.WriteString(structs.GetPurchaseNo());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("purchaseNo can not be null!");
				}
				
				
				if(structs.GetExportType() != null) {
					
					oprot.WriteFieldBegin("exportType");
					oprot.WriteString(structs.GetExportType());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("exportType can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(exportAsync_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class exportPoHead_argsHelper : TBeanSerializer<exportPoHead_args>
		{
			
			public static exportPoHead_argsHelper OBJ = new exportPoHead_argsHelper();
			
			public static exportPoHead_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(exportPoHead_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetPurchaseNo(value);
				}
				
				
				
				
				
				if(true){
					
					com.vip.xstore.cc.bulkbuying.service.PurchaseOrderQueryModel value;
					
					value = new com.vip.xstore.cc.bulkbuying.service.PurchaseOrderQueryModel();
					com.vip.xstore.cc.bulkbuying.service.PurchaseOrderQueryModelHelper.getInstance().Read(value, iprot);
					
					structs.SetPurchaseOrderQueryModel(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(exportPoHead_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetPurchaseNo() != null) {
					
					oprot.WriteFieldBegin("purchaseNo");
					oprot.WriteString(structs.GetPurchaseNo());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetPurchaseOrderQueryModel() != null) {
					
					oprot.WriteFieldBegin("purchaseOrderQueryModel");
					
					com.vip.xstore.cc.bulkbuying.service.PurchaseOrderQueryModelHelper.getInstance().Write(structs.GetPurchaseOrderQueryModel(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(exportPoHead_args bean){
				
				
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
		
		
		
		
		public class queryMyApprovedPo_argsHelper : TBeanSerializer<queryMyApprovedPo_args>
		{
			
			public static queryMyApprovedPo_argsHelper OBJ = new queryMyApprovedPo_argsHelper();
			
			public static queryMyApprovedPo_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryMyApprovedPo_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.xstore.cc.bulkbuying.service.QueryMyApprovedPoReq value;
					
					value = new com.vip.xstore.cc.bulkbuying.service.QueryMyApprovedPoReq();
					com.vip.xstore.cc.bulkbuying.service.QueryMyApprovedPoReqHelper.getInstance().Read(value, iprot);
					
					structs.SetReq(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryMyApprovedPo_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetReq() != null) {
					
					oprot.WriteFieldBegin("req");
					
					com.vip.xstore.cc.bulkbuying.service.QueryMyApprovedPoReqHelper.getInstance().Write(structs.GetReq(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryMyApprovedPo_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class select_argsHelper : TBeanSerializer<select_args>
		{
			
			public static select_argsHelper OBJ = new select_argsHelper();
			
			public static select_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(select_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetPurchaseNo(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(select_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetPurchaseNo() != null) {
					
					oprot.WriteFieldBegin("purchaseNo");
					oprot.WriteString(structs.GetPurchaseNo());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(select_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class selectAll_argsHelper : TBeanSerializer<selectAll_args>
		{
			
			public static selectAll_argsHelper OBJ = new selectAll_argsHelper();
			
			public static selectAll_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(selectAll_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.xstore.cc.bulkbuying.service.PurchaseOrderSelectAllReq value;
					
					value = new com.vip.xstore.cc.bulkbuying.service.PurchaseOrderSelectAllReq();
					com.vip.xstore.cc.bulkbuying.service.PurchaseOrderSelectAllReqHelper.getInstance().Read(value, iprot);
					
					structs.SetSelectAllReq(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(selectAll_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSelectAllReq() != null) {
					
					oprot.WriteFieldBegin("selectAllReq");
					
					com.vip.xstore.cc.bulkbuying.service.PurchaseOrderSelectAllReqHelper.getInstance().Write(structs.GetSelectAllReq(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(selectAll_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class selectPage_argsHelper : TBeanSerializer<selectPage_args>
		{
			
			public static selectPage_argsHelper OBJ = new selectPage_argsHelper();
			
			public static selectPage_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(selectPage_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.xstore.cc.bulkbuying.service.PurchaseOrderQueryModel value;
					
					value = new com.vip.xstore.cc.bulkbuying.service.PurchaseOrderQueryModel();
					com.vip.xstore.cc.bulkbuying.service.PurchaseOrderQueryModelHelper.getInstance().Read(value, iprot);
					
					structs.SetPurchaseOrderQueryModel(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(selectPage_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetPurchaseOrderQueryModel() != null) {
					
					oprot.WriteFieldBegin("purchaseOrderQueryModel");
					
					com.vip.xstore.cc.bulkbuying.service.PurchaseOrderQueryModelHelper.getInstance().Write(structs.GetPurchaseOrderQueryModel(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(selectPage_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class statPoByGroup_argsHelper : TBeanSerializer<statPoByGroup_args>
		{
			
			public static statPoByGroup_argsHelper OBJ = new statPoByGroup_argsHelper();
			
			public static statPoByGroup_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(statPoByGroup_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.xstore.cc.bulkbuying.service.StatPoCommonReq value;
					
					value = new com.vip.xstore.cc.bulkbuying.service.StatPoCommonReq();
					com.vip.xstore.cc.bulkbuying.service.StatPoCommonReqHelper.getInstance().Read(value, iprot);
					
					structs.SetReq(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(statPoByGroup_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetReq() != null) {
					
					oprot.WriteFieldBegin("req");
					
					com.vip.xstore.cc.bulkbuying.service.StatPoCommonReqHelper.getInstance().Write(structs.GetReq(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("req can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(statPoByGroup_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class update_argsHelper : TBeanSerializer<update_args>
		{
			
			public static update_argsHelper OBJ = new update_argsHelper();
			
			public static update_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(update_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.xstore.cc.bulkbuying.service.PurchaseOrderUpdateRequest value;
					
					value = new com.vip.xstore.cc.bulkbuying.service.PurchaseOrderUpdateRequest();
					com.vip.xstore.cc.bulkbuying.service.PurchaseOrderUpdateRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(update_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					com.vip.xstore.cc.bulkbuying.service.PurchaseOrderUpdateRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("request can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(update_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class updatePoDistributableGoodsTime_argsHelper : TBeanSerializer<updatePoDistributableGoodsTime_args>
		{
			
			public static updatePoDistributableGoodsTime_argsHelper OBJ = new updatePoDistributableGoodsTime_argsHelper();
			
			public static updatePoDistributableGoodsTime_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updatePoDistributableGoodsTime_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetPurchaseNo(value);
				}
				
				
				
				
				
				if(true){
					
					System.DateTime value;
					value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
					
					structs.SetDistributableGoodsTime(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updatePoDistributableGoodsTime_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetPurchaseNo() != null) {
					
					oprot.WriteFieldBegin("purchaseNo");
					oprot.WriteString(structs.GetPurchaseNo());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("purchaseNo can not be null!");
				}
				
				
				if(structs.GetDistributableGoodsTime() != null) {
					
					oprot.WriteFieldBegin("distributableGoodsTime");
					oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetDistributableGoodsTime())); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("distributableGoodsTime can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(updatePoDistributableGoodsTime_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class complementBarcodeOriginOfOuterPurchase_resultHelper : TBeanSerializer<complementBarcodeOriginOfOuterPurchase_result>
		{
			
			public static complementBarcodeOriginOfOuterPurchase_resultHelper OBJ = new complementBarcodeOriginOfOuterPurchase_resultHelper();
			
			public static complementBarcodeOriginOfOuterPurchase_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(complementBarcodeOriginOfOuterPurchase_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(complementBarcodeOriginOfOuterPurchase_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(complementBarcodeOriginOfOuterPurchase_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class delete_resultHelper : TBeanSerializer<delete_result>
		{
			
			public static delete_resultHelper OBJ = new delete_resultHelper();
			
			public static delete_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(delete_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					int value;
					value = iprot.ReadI32(); 
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(delete_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteI32((int)structs.GetSuccess()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("success can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(delete_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class doImport_resultHelper : TBeanSerializer<doImport_result>
		{
			
			public static doImport_resultHelper OBJ = new doImport_resultHelper();
			
			public static doImport_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(doImport_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.xstore.cc.bulkbuying.service.PurchaseOrderImportResponse value;
					
					value = new com.vip.xstore.cc.bulkbuying.service.PurchaseOrderImportResponse();
					com.vip.xstore.cc.bulkbuying.service.PurchaseOrderImportResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(doImport_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.xstore.cc.bulkbuying.service.PurchaseOrderImportResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(doImport_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class export_resultHelper : TBeanSerializer<export_result>
		{
			
			public static export_resultHelper OBJ = new export_resultHelper();
			
			public static export_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(export_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.xstore.cc.bulkbuying.service.PurchaseOrderResult value;
					
					value = new com.vip.xstore.cc.bulkbuying.service.PurchaseOrderResult();
					com.vip.xstore.cc.bulkbuying.service.PurchaseOrderResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(export_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.xstore.cc.bulkbuying.service.PurchaseOrderResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(export_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class exportAsync_resultHelper : TBeanSerializer<exportAsync_result>
		{
			
			public static exportAsync_resultHelper OBJ = new exportAsync_resultHelper();
			
			public static exportAsync_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(exportAsync_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					bool value;
					value = iprot.ReadBool();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(exportAsync_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteBool((bool)structs.GetSuccess());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("success can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(exportAsync_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class exportPoHead_resultHelper : TBeanSerializer<exportPoHead_result>
		{
			
			public static exportPoHead_resultHelper OBJ = new exportPoHead_resultHelper();
			
			public static exportPoHead_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(exportPoHead_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.xstore.cc.bulkbuying.service.PurchaseOrderResult value;
					
					value = new com.vip.xstore.cc.bulkbuying.service.PurchaseOrderResult();
					com.vip.xstore.cc.bulkbuying.service.PurchaseOrderResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(exportPoHead_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.xstore.cc.bulkbuying.service.PurchaseOrderResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(exportPoHead_result bean){
				
				
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
		
		
		
		
		public class queryMyApprovedPo_resultHelper : TBeanSerializer<queryMyApprovedPo_result>
		{
			
			public static queryMyApprovedPo_resultHelper OBJ = new queryMyApprovedPo_resultHelper();
			
			public static queryMyApprovedPo_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryMyApprovedPo_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.xstore.cc.bulkbuying.service.PurchaseOrderModelResult value;
					
					value = new com.vip.xstore.cc.bulkbuying.service.PurchaseOrderModelResult();
					com.vip.xstore.cc.bulkbuying.service.PurchaseOrderModelResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryMyApprovedPo_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.xstore.cc.bulkbuying.service.PurchaseOrderModelResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryMyApprovedPo_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class select_resultHelper : TBeanSerializer<select_result>
		{
			
			public static select_resultHelper OBJ = new select_resultHelper();
			
			public static select_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(select_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.xstore.cc.bulkbuying.service.PurchaseOrderModel> value;
					
					value = new List<com.vip.xstore.cc.bulkbuying.service.PurchaseOrderModel>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.xstore.cc.bulkbuying.service.PurchaseOrderModel elem0;
							
							elem0 = new com.vip.xstore.cc.bulkbuying.service.PurchaseOrderModel();
							com.vip.xstore.cc.bulkbuying.service.PurchaseOrderModelHelper.getInstance().Read(elem0, iprot);
							
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
			
			
			public void Write(select_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.xstore.cc.bulkbuying.service.PurchaseOrderModel _item0 in structs.GetSuccess()){
						
						
						com.vip.xstore.cc.bulkbuying.service.PurchaseOrderModelHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(select_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class selectAll_resultHelper : TBeanSerializer<selectAll_result>
		{
			
			public static selectAll_resultHelper OBJ = new selectAll_resultHelper();
			
			public static selectAll_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(selectAll_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.xstore.cc.bulkbuying.service.PurchaseOrderModel> value;
					
					value = new List<com.vip.xstore.cc.bulkbuying.service.PurchaseOrderModel>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.xstore.cc.bulkbuying.service.PurchaseOrderModel elem1;
							
							elem1 = new com.vip.xstore.cc.bulkbuying.service.PurchaseOrderModel();
							com.vip.xstore.cc.bulkbuying.service.PurchaseOrderModelHelper.getInstance().Read(elem1, iprot);
							
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
			
			
			public void Write(selectAll_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.xstore.cc.bulkbuying.service.PurchaseOrderModel _item0 in structs.GetSuccess()){
						
						
						com.vip.xstore.cc.bulkbuying.service.PurchaseOrderModelHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(selectAll_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class selectPage_resultHelper : TBeanSerializer<selectPage_result>
		{
			
			public static selectPage_resultHelper OBJ = new selectPage_resultHelper();
			
			public static selectPage_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(selectPage_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.xstore.cc.bulkbuying.service.PurchaseOrderModelResult value;
					
					value = new com.vip.xstore.cc.bulkbuying.service.PurchaseOrderModelResult();
					com.vip.xstore.cc.bulkbuying.service.PurchaseOrderModelResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(selectPage_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.xstore.cc.bulkbuying.service.PurchaseOrderModelResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(selectPage_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class statPoByGroup_resultHelper : TBeanSerializer<statPoByGroup_result>
		{
			
			public static statPoByGroup_resultHelper OBJ = new statPoByGroup_resultHelper();
			
			public static statPoByGroup_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(statPoByGroup_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.xstore.cc.bulkbuying.service.StatPoByGroupResp value;
					
					value = new com.vip.xstore.cc.bulkbuying.service.StatPoByGroupResp();
					com.vip.xstore.cc.bulkbuying.service.StatPoByGroupRespHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(statPoByGroup_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.xstore.cc.bulkbuying.service.StatPoByGroupRespHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(statPoByGroup_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class update_resultHelper : TBeanSerializer<update_result>
		{
			
			public static update_resultHelper OBJ = new update_resultHelper();
			
			public static update_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(update_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					bool value;
					value = iprot.ReadBool();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(update_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteBool((bool)structs.GetSuccess());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("success can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(update_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class updatePoDistributableGoodsTime_resultHelper : TBeanSerializer<updatePoDistributableGoodsTime_result>
		{
			
			public static updatePoDistributableGoodsTime_resultHelper OBJ = new updatePoDistributableGoodsTime_resultHelper();
			
			public static updatePoDistributableGoodsTime_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updatePoDistributableGoodsTime_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updatePoDistributableGoodsTime_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(updatePoDistributableGoodsTime_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class PurchaseOrderServiceClient : OspRestStub , PurchaseOrderService  {
			
			
			public PurchaseOrderServiceClient():base("com.vip.xstore.cc.bulkbuying.service.PurchaseOrderService","1.0.0") {
				
				
			}
			
			
			
			public void complementBarcodeOriginOfOuterPurchase() {
				
				send_complementBarcodeOriginOfOuterPurchase();
				recv_complementBarcodeOriginOfOuterPurchase();
				
			}
			
			
			private void send_complementBarcodeOriginOfOuterPurchase(){
				
				InitInvocation("complementBarcodeOriginOfOuterPurchase");
				
				complementBarcodeOriginOfOuterPurchase_args args = new complementBarcodeOriginOfOuterPurchase_args();
				
				SendBase(args, complementBarcodeOriginOfOuterPurchase_argsHelper.getInstance());
			}
			
			
			private void recv_complementBarcodeOriginOfOuterPurchase(){
				
				complementBarcodeOriginOfOuterPurchase_result result = new complementBarcodeOriginOfOuterPurchase_result();
				ReceiveBase(result, complementBarcodeOriginOfOuterPurchase_resultHelper.getInstance());
				
				
			}
			
			
			public int? delete(List<string> purchaseNo_) {
				
				send_delete(purchaseNo_);
				return recv_delete(); 
				
			}
			
			
			private void send_delete(List<string> purchaseNo_){
				
				InitInvocation("delete");
				
				delete_args args = new delete_args();
				args.SetPurchaseNo(purchaseNo_);
				
				SendBase(args, delete_argsHelper.getInstance());
			}
			
			
			private int? recv_delete(){
				
				delete_result result = new delete_result();
				ReceiveBase(result, delete_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.xstore.cc.bulkbuying.service.PurchaseOrderImportResponse doImport(com.vip.xstore.cc.bulkbuying.service.PurchaseOrderImportRequest request_) {
				
				send_doImport(request_);
				return recv_doImport(); 
				
			}
			
			
			private void send_doImport(com.vip.xstore.cc.bulkbuying.service.PurchaseOrderImportRequest request_){
				
				InitInvocation("doImport");
				
				doImport_args args = new doImport_args();
				args.SetRequest(request_);
				
				SendBase(args, doImport_argsHelper.getInstance());
			}
			
			
			private com.vip.xstore.cc.bulkbuying.service.PurchaseOrderImportResponse recv_doImport(){
				
				doImport_result result = new doImport_result();
				ReceiveBase(result, doImport_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.xstore.cc.bulkbuying.service.PurchaseOrderResult export(string purchaseNo_,int exportType_) {
				
				send_export(purchaseNo_,exportType_);
				return recv_export(); 
				
			}
			
			
			private void send_export(string purchaseNo_,int exportType_){
				
				InitInvocation("export");
				
				export_args args = new export_args();
				args.SetPurchaseNo(purchaseNo_);
				args.SetExportType(exportType_);
				
				SendBase(args, export_argsHelper.getInstance());
			}
			
			
			private com.vip.xstore.cc.bulkbuying.service.PurchaseOrderResult recv_export(){
				
				export_result result = new export_result();
				ReceiveBase(result, export_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public bool? exportAsync(string purchaseNo_,string exportType_) {
				
				send_exportAsync(purchaseNo_,exportType_);
				return recv_exportAsync(); 
				
			}
			
			
			private void send_exportAsync(string purchaseNo_,string exportType_){
				
				InitInvocation("exportAsync");
				
				exportAsync_args args = new exportAsync_args();
				args.SetPurchaseNo(purchaseNo_);
				args.SetExportType(exportType_);
				
				SendBase(args, exportAsync_argsHelper.getInstance());
			}
			
			
			private bool? recv_exportAsync(){
				
				exportAsync_result result = new exportAsync_result();
				ReceiveBase(result, exportAsync_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.xstore.cc.bulkbuying.service.PurchaseOrderResult exportPoHead(string purchaseNo_,com.vip.xstore.cc.bulkbuying.service.PurchaseOrderQueryModel purchaseOrderQueryModel_) {
				
				send_exportPoHead(purchaseNo_,purchaseOrderQueryModel_);
				return recv_exportPoHead(); 
				
			}
			
			
			private void send_exportPoHead(string purchaseNo_,com.vip.xstore.cc.bulkbuying.service.PurchaseOrderQueryModel purchaseOrderQueryModel_){
				
				InitInvocation("exportPoHead");
				
				exportPoHead_args args = new exportPoHead_args();
				args.SetPurchaseNo(purchaseNo_);
				args.SetPurchaseOrderQueryModel(purchaseOrderQueryModel_);
				
				SendBase(args, exportPoHead_argsHelper.getInstance());
			}
			
			
			private com.vip.xstore.cc.bulkbuying.service.PurchaseOrderResult recv_exportPoHead(){
				
				exportPoHead_result result = new exportPoHead_result();
				ReceiveBase(result, exportPoHead_resultHelper.getInstance());
				
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
			
			
			public com.vip.xstore.cc.bulkbuying.service.PurchaseOrderModelResult queryMyApprovedPo(com.vip.xstore.cc.bulkbuying.service.QueryMyApprovedPoReq req_) {
				
				send_queryMyApprovedPo(req_);
				return recv_queryMyApprovedPo(); 
				
			}
			
			
			private void send_queryMyApprovedPo(com.vip.xstore.cc.bulkbuying.service.QueryMyApprovedPoReq req_){
				
				InitInvocation("queryMyApprovedPo");
				
				queryMyApprovedPo_args args = new queryMyApprovedPo_args();
				args.SetReq(req_);
				
				SendBase(args, queryMyApprovedPo_argsHelper.getInstance());
			}
			
			
			private com.vip.xstore.cc.bulkbuying.service.PurchaseOrderModelResult recv_queryMyApprovedPo(){
				
				queryMyApprovedPo_result result = new queryMyApprovedPo_result();
				ReceiveBase(result, queryMyApprovedPo_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<com.vip.xstore.cc.bulkbuying.service.PurchaseOrderModel> select(string purchaseNo_) {
				
				send_select(purchaseNo_);
				return recv_select(); 
				
			}
			
			
			private void send_select(string purchaseNo_){
				
				InitInvocation("select");
				
				select_args args = new select_args();
				args.SetPurchaseNo(purchaseNo_);
				
				SendBase(args, select_argsHelper.getInstance());
			}
			
			
			private List<com.vip.xstore.cc.bulkbuying.service.PurchaseOrderModel> recv_select(){
				
				select_result result = new select_result();
				ReceiveBase(result, select_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<com.vip.xstore.cc.bulkbuying.service.PurchaseOrderModel> selectAll(com.vip.xstore.cc.bulkbuying.service.PurchaseOrderSelectAllReq selectAllReq_) {
				
				send_selectAll(selectAllReq_);
				return recv_selectAll(); 
				
			}
			
			
			private void send_selectAll(com.vip.xstore.cc.bulkbuying.service.PurchaseOrderSelectAllReq selectAllReq_){
				
				InitInvocation("selectAll");
				
				selectAll_args args = new selectAll_args();
				args.SetSelectAllReq(selectAllReq_);
				
				SendBase(args, selectAll_argsHelper.getInstance());
			}
			
			
			private List<com.vip.xstore.cc.bulkbuying.service.PurchaseOrderModel> recv_selectAll(){
				
				selectAll_result result = new selectAll_result();
				ReceiveBase(result, selectAll_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.xstore.cc.bulkbuying.service.PurchaseOrderModelResult selectPage(com.vip.xstore.cc.bulkbuying.service.PurchaseOrderQueryModel purchaseOrderQueryModel_) {
				
				send_selectPage(purchaseOrderQueryModel_);
				return recv_selectPage(); 
				
			}
			
			
			private void send_selectPage(com.vip.xstore.cc.bulkbuying.service.PurchaseOrderQueryModel purchaseOrderQueryModel_){
				
				InitInvocation("selectPage");
				
				selectPage_args args = new selectPage_args();
				args.SetPurchaseOrderQueryModel(purchaseOrderQueryModel_);
				
				SendBase(args, selectPage_argsHelper.getInstance());
			}
			
			
			private com.vip.xstore.cc.bulkbuying.service.PurchaseOrderModelResult recv_selectPage(){
				
				selectPage_result result = new selectPage_result();
				ReceiveBase(result, selectPage_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.xstore.cc.bulkbuying.service.StatPoByGroupResp statPoByGroup(com.vip.xstore.cc.bulkbuying.service.StatPoCommonReq req_) {
				
				send_statPoByGroup(req_);
				return recv_statPoByGroup(); 
				
			}
			
			
			private void send_statPoByGroup(com.vip.xstore.cc.bulkbuying.service.StatPoCommonReq req_){
				
				InitInvocation("statPoByGroup");
				
				statPoByGroup_args args = new statPoByGroup_args();
				args.SetReq(req_);
				
				SendBase(args, statPoByGroup_argsHelper.getInstance());
			}
			
			
			private com.vip.xstore.cc.bulkbuying.service.StatPoByGroupResp recv_statPoByGroup(){
				
				statPoByGroup_result result = new statPoByGroup_result();
				ReceiveBase(result, statPoByGroup_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public bool? update(com.vip.xstore.cc.bulkbuying.service.PurchaseOrderUpdateRequest request_) {
				
				send_update(request_);
				return recv_update(); 
				
			}
			
			
			private void send_update(com.vip.xstore.cc.bulkbuying.service.PurchaseOrderUpdateRequest request_){
				
				InitInvocation("update");
				
				update_args args = new update_args();
				args.SetRequest(request_);
				
				SendBase(args, update_argsHelper.getInstance());
			}
			
			
			private bool? recv_update(){
				
				update_result result = new update_result();
				ReceiveBase(result, update_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public void updatePoDistributableGoodsTime(string purchaseNo_,System.DateTime distributableGoodsTime_) {
				
				send_updatePoDistributableGoodsTime(purchaseNo_,distributableGoodsTime_);
				recv_updatePoDistributableGoodsTime();
				
			}
			
			
			private void send_updatePoDistributableGoodsTime(string purchaseNo_,System.DateTime distributableGoodsTime_){
				
				InitInvocation("updatePoDistributableGoodsTime");
				
				updatePoDistributableGoodsTime_args args = new updatePoDistributableGoodsTime_args();
				args.SetPurchaseNo(purchaseNo_);
				args.SetDistributableGoodsTime(distributableGoodsTime_);
				
				SendBase(args, updatePoDistributableGoodsTime_argsHelper.getInstance());
			}
			
			
			private void recv_updatePoDistributableGoodsTime(){
				
				updatePoDistributableGoodsTime_result result = new updatePoDistributableGoodsTime_result();
				ReceiveBase(result, updatePoDistributableGoodsTime_resultHelper.getInstance());
				
				
			}
			
			
		}
		
		
	}
	
}