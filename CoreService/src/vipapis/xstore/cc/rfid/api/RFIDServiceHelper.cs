using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace vipapis.xstore.cc.rfid.api{
	
	
	public class RFIDServiceHelper {
		
		
		
		public class addRfid2BarcodeMapping_args {
			
			///<summary>
			/// 添加映射关系入参
			///</summary>
			
			private vipapis.xstore.cc.rfid.api.RfidDataRequest request_;
			
			public vipapis.xstore.cc.rfid.api.RfidDataRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(vipapis.xstore.cc.rfid.api.RfidDataRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class batchAddRfid2BarcodeMapping_args {
			
			///<summary>
			/// 批量添加映射关系入参
			///</summary>
			
			private List<vipapis.xstore.cc.rfid.api.RfidDataRequest> requests_;
			
			public List<vipapis.xstore.cc.rfid.api.RfidDataRequest> GetRequests(){
				return this.requests_;
			}
			
			public void SetRequests(List<vipapis.xstore.cc.rfid.api.RfidDataRequest> value){
				this.requests_ = value;
			}
			
		}
		
		
		
		
		public class generateExternalCode_args {
			
			///<summary>
			/// 新条码
			///</summary>
			
			private string barcode_;
			
			///<summary>
			/// 主体
			///</summary>
			
			private string owner_;
			
			///<summary>
			/// 老条码
			///</summary>
			
			private string oldBarcode_;
			
			public string GetBarcode(){
				return this.barcode_;
			}
			
			public void SetBarcode(string value){
				this.barcode_ = value;
			}
			public string GetOwner(){
				return this.owner_;
			}
			
			public void SetOwner(string value){
				this.owner_ = value;
			}
			public string GetOldBarcode(){
				return this.oldBarcode_;
			}
			
			public void SetOldBarcode(string value){
				this.oldBarcode_ = value;
			}
			
		}
		
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class queryBarcodeByExternalCode_args {
			
			///<summary>
			/// 外部码
			///</summary>
			
			private string externalCode_;
			
			///<summary>
			/// 主体
			///</summary>
			
			private string owner_;
			
			public string GetExternalCode(){
				return this.externalCode_;
			}
			
			public void SetExternalCode(string value){
				this.externalCode_ = value;
			}
			public string GetOwner(){
				return this.owner_;
			}
			
			public void SetOwner(string value){
				this.owner_ = value;
			}
			
		}
		
		
		
		
		public class queryBarcodeByRfid_args {
			
			///<summary>
			/// RFID
			///</summary>
			
			private string rfid_;
			
			///<summary>
			/// owner
			///</summary>
			
			private string owner_;
			
			public string GetRfid(){
				return this.rfid_;
			}
			
			public void SetRfid(string value){
				this.rfid_ = value;
			}
			public string GetOwner(){
				return this.owner_;
			}
			
			public void SetOwner(string value){
				this.owner_ = value;
			}
			
		}
		
		
		
		
		public class queryEpcStatus_args {
			
			///<summary>
			/// epc码
			///</summary>
			
			private string epc_;
			
			///<summary>
			/// 主体
			///</summary>
			
			private string owner_;
			
			public string GetEpc(){
				return this.epc_;
			}
			
			public void SetEpc(string value){
				this.epc_ = value;
			}
			public string GetOwner(){
				return this.owner_;
			}
			
			public void SetOwner(string value){
				this.owner_ = value;
			}
			
		}
		
		
		
		
		public class queryRfidSyncResult_args {
			
			///<summary>
			/// 条码,一批最多500个
			///</summary>
			
			private List<string> barcodes_;
			
			///<summary>
			/// 主体
			///</summary>
			
			private string owner_;
			
			public List<string> GetBarcodes(){
				return this.barcodes_;
			}
			
			public void SetBarcodes(List<string> value){
				this.barcodes_ = value;
			}
			public string GetOwner(){
				return this.owner_;
			}
			
			public void SetOwner(string value){
				this.owner_ = value;
			}
			
		}
		
		
		
		
		public class uploadEpc_args {
			
			///<summary>
			/// EPC上抛入参
			///</summary>
			
			private vipapis.xstore.cc.rfid.api.RfidEpcParamModel epc_;
			
			public vipapis.xstore.cc.rfid.api.RfidEpcParamModel GetEpc(){
				return this.epc_;
			}
			
			public void SetEpc(vipapis.xstore.cc.rfid.api.RfidEpcParamModel value){
				this.epc_ = value;
			}
			
		}
		
		
		
		
		public class addRfid2BarcodeMapping_result {
			
			///<summary>
			/// 添加映射关系结果
			///</summary>
			
			private vipapis.xstore.cc.rfid.api.RfidDataResponse success_;
			
			public vipapis.xstore.cc.rfid.api.RfidDataResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.xstore.cc.rfid.api.RfidDataResponse value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class batchAddRfid2BarcodeMapping_result {
			
			///<summary>
			/// 添加映射关系结果
			///</summary>
			
			private List<vipapis.xstore.cc.rfid.api.RfidDataResponse> success_;
			
			public List<vipapis.xstore.cc.rfid.api.RfidDataResponse> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<vipapis.xstore.cc.rfid.api.RfidDataResponse> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class generateExternalCode_result {
			
			///<summary>
			/// 返回外部码
			///</summary>
			
			private string success_;
			
			public string GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(string value){
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
		
		
		
		
		public class queryBarcodeByExternalCode_result {
			
			///<summary>
			/// 返回barcode
			///</summary>
			
			private string success_;
			
			public string GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(string value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class queryBarcodeByRfid_result {
			
			///<summary>
			/// 返回barcode
			///</summary>
			
			private string success_;
			
			public string GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(string value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class queryEpcStatus_result {
			
			///<summary>
			/// 返回epc状态对象，查询不到记录返回空
			///</summary>
			
			private vipapis.xstore.cc.rfid.api.RfidEpcStatusResponse success_;
			
			public vipapis.xstore.cc.rfid.api.RfidEpcStatusResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.xstore.cc.rfid.api.RfidEpcStatusResponse value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class queryRfidSyncResult_result {
			
			///<summary>
			/// 返回分发结果
			///</summary>
			
			private List<vipapis.xstore.cc.rfid.api.RfidSyncResultResponse> success_;
			
			public List<vipapis.xstore.cc.rfid.api.RfidSyncResultResponse> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<vipapis.xstore.cc.rfid.api.RfidSyncResultResponse> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class uploadEpc_result {
			
			///<summary>
			/// 返回成功与否
			///</summary>
			
			private bool? success_;
			
			public bool? GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(bool? value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		
		public class addRfid2BarcodeMapping_argsHelper : TBeanSerializer<addRfid2BarcodeMapping_args>
		{
			
			public static addRfid2BarcodeMapping_argsHelper OBJ = new addRfid2BarcodeMapping_argsHelper();
			
			public static addRfid2BarcodeMapping_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(addRfid2BarcodeMapping_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.xstore.cc.rfid.api.RfidDataRequest value;
					
					value = new vipapis.xstore.cc.rfid.api.RfidDataRequest();
					vipapis.xstore.cc.rfid.api.RfidDataRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(addRfid2BarcodeMapping_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					vipapis.xstore.cc.rfid.api.RfidDataRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("request can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(addRfid2BarcodeMapping_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class batchAddRfid2BarcodeMapping_argsHelper : TBeanSerializer<batchAddRfid2BarcodeMapping_args>
		{
			
			public static batchAddRfid2BarcodeMapping_argsHelper OBJ = new batchAddRfid2BarcodeMapping_argsHelper();
			
			public static batchAddRfid2BarcodeMapping_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(batchAddRfid2BarcodeMapping_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<vipapis.xstore.cc.rfid.api.RfidDataRequest> value;
					
					value = new List<vipapis.xstore.cc.rfid.api.RfidDataRequest>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							vipapis.xstore.cc.rfid.api.RfidDataRequest elem0;
							
							elem0 = new vipapis.xstore.cc.rfid.api.RfidDataRequest();
							vipapis.xstore.cc.rfid.api.RfidDataRequestHelper.getInstance().Read(elem0, iprot);
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetRequests(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(batchAddRfid2BarcodeMapping_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequests() != null) {
					
					oprot.WriteFieldBegin("requests");
					
					oprot.WriteListBegin();
					foreach(vipapis.xstore.cc.rfid.api.RfidDataRequest _item0 in structs.GetRequests()){
						
						
						vipapis.xstore.cc.rfid.api.RfidDataRequestHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("requests can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(batchAddRfid2BarcodeMapping_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class generateExternalCode_argsHelper : TBeanSerializer<generateExternalCode_args>
		{
			
			public static generateExternalCode_argsHelper OBJ = new generateExternalCode_argsHelper();
			
			public static generateExternalCode_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(generateExternalCode_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetBarcode(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetOwner(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetOldBarcode(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(generateExternalCode_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetBarcode() != null) {
					
					oprot.WriteFieldBegin("barcode");
					oprot.WriteString(structs.GetBarcode());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("barcode can not be null!");
				}
				
				
				if(structs.GetOwner() != null) {
					
					oprot.WriteFieldBegin("owner");
					oprot.WriteString(structs.GetOwner());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("owner can not be null!");
				}
				
				
				if(structs.GetOldBarcode() != null) {
					
					oprot.WriteFieldBegin("oldBarcode");
					oprot.WriteString(structs.GetOldBarcode());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("oldBarcode can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(generateExternalCode_args bean){
				
				
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
		
		
		
		
		public class queryBarcodeByExternalCode_argsHelper : TBeanSerializer<queryBarcodeByExternalCode_args>
		{
			
			public static queryBarcodeByExternalCode_argsHelper OBJ = new queryBarcodeByExternalCode_argsHelper();
			
			public static queryBarcodeByExternalCode_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryBarcodeByExternalCode_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetExternalCode(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetOwner(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryBarcodeByExternalCode_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetExternalCode() != null) {
					
					oprot.WriteFieldBegin("externalCode");
					oprot.WriteString(structs.GetExternalCode());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("externalCode can not be null!");
				}
				
				
				if(structs.GetOwner() != null) {
					
					oprot.WriteFieldBegin("owner");
					oprot.WriteString(structs.GetOwner());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("owner can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryBarcodeByExternalCode_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class queryBarcodeByRfid_argsHelper : TBeanSerializer<queryBarcodeByRfid_args>
		{
			
			public static queryBarcodeByRfid_argsHelper OBJ = new queryBarcodeByRfid_argsHelper();
			
			public static queryBarcodeByRfid_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryBarcodeByRfid_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetRfid(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetOwner(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryBarcodeByRfid_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRfid() != null) {
					
					oprot.WriteFieldBegin("rfid");
					oprot.WriteString(structs.GetRfid());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("rfid can not be null!");
				}
				
				
				if(structs.GetOwner() != null) {
					
					oprot.WriteFieldBegin("owner");
					oprot.WriteString(structs.GetOwner());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("owner can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryBarcodeByRfid_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class queryEpcStatus_argsHelper : TBeanSerializer<queryEpcStatus_args>
		{
			
			public static queryEpcStatus_argsHelper OBJ = new queryEpcStatus_argsHelper();
			
			public static queryEpcStatus_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryEpcStatus_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetEpc(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetOwner(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryEpcStatus_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetEpc() != null) {
					
					oprot.WriteFieldBegin("epc");
					oprot.WriteString(structs.GetEpc());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("epc can not be null!");
				}
				
				
				if(structs.GetOwner() != null) {
					
					oprot.WriteFieldBegin("owner");
					oprot.WriteString(structs.GetOwner());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryEpcStatus_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class queryRfidSyncResult_argsHelper : TBeanSerializer<queryRfidSyncResult_args>
		{
			
			public static queryRfidSyncResult_argsHelper OBJ = new queryRfidSyncResult_argsHelper();
			
			public static queryRfidSyncResult_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryRfidSyncResult_args structs, Protocol iprot){
				
				
				
				
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
					
					structs.SetBarcodes(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetOwner(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryRfidSyncResult_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetBarcodes() != null) {
					
					oprot.WriteFieldBegin("barcodes");
					
					oprot.WriteListBegin();
					foreach(string _item0 in structs.GetBarcodes()){
						
						oprot.WriteString(_item0);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("barcodes can not be null!");
				}
				
				
				if(structs.GetOwner() != null) {
					
					oprot.WriteFieldBegin("owner");
					oprot.WriteString(structs.GetOwner());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("owner can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryRfidSyncResult_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class uploadEpc_argsHelper : TBeanSerializer<uploadEpc_args>
		{
			
			public static uploadEpc_argsHelper OBJ = new uploadEpc_argsHelper();
			
			public static uploadEpc_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(uploadEpc_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.xstore.cc.rfid.api.RfidEpcParamModel value;
					
					value = new vipapis.xstore.cc.rfid.api.RfidEpcParamModel();
					vipapis.xstore.cc.rfid.api.RfidEpcParamModelHelper.getInstance().Read(value, iprot);
					
					structs.SetEpc(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(uploadEpc_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetEpc() != null) {
					
					oprot.WriteFieldBegin("epc");
					
					vipapis.xstore.cc.rfid.api.RfidEpcParamModelHelper.getInstance().Write(structs.GetEpc(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("epc can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(uploadEpc_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class addRfid2BarcodeMapping_resultHelper : TBeanSerializer<addRfid2BarcodeMapping_result>
		{
			
			public static addRfid2BarcodeMapping_resultHelper OBJ = new addRfid2BarcodeMapping_resultHelper();
			
			public static addRfid2BarcodeMapping_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(addRfid2BarcodeMapping_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.xstore.cc.rfid.api.RfidDataResponse value;
					
					value = new vipapis.xstore.cc.rfid.api.RfidDataResponse();
					vipapis.xstore.cc.rfid.api.RfidDataResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(addRfid2BarcodeMapping_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.xstore.cc.rfid.api.RfidDataResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(addRfid2BarcodeMapping_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class batchAddRfid2BarcodeMapping_resultHelper : TBeanSerializer<batchAddRfid2BarcodeMapping_result>
		{
			
			public static batchAddRfid2BarcodeMapping_resultHelper OBJ = new batchAddRfid2BarcodeMapping_resultHelper();
			
			public static batchAddRfid2BarcodeMapping_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(batchAddRfid2BarcodeMapping_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<vipapis.xstore.cc.rfid.api.RfidDataResponse> value;
					
					value = new List<vipapis.xstore.cc.rfid.api.RfidDataResponse>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							vipapis.xstore.cc.rfid.api.RfidDataResponse elem0;
							
							elem0 = new vipapis.xstore.cc.rfid.api.RfidDataResponse();
							vipapis.xstore.cc.rfid.api.RfidDataResponseHelper.getInstance().Read(elem0, iprot);
							
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
			
			
			public void Write(batchAddRfid2BarcodeMapping_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(vipapis.xstore.cc.rfid.api.RfidDataResponse _item0 in structs.GetSuccess()){
						
						
						vipapis.xstore.cc.rfid.api.RfidDataResponseHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(batchAddRfid2BarcodeMapping_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class generateExternalCode_resultHelper : TBeanSerializer<generateExternalCode_result>
		{
			
			public static generateExternalCode_resultHelper OBJ = new generateExternalCode_resultHelper();
			
			public static generateExternalCode_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(generateExternalCode_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(generateExternalCode_result structs, Protocol oprot){
				
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
			
			
			public void Validate(generateExternalCode_result bean){
				
				
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
		
		
		
		
		public class queryBarcodeByExternalCode_resultHelper : TBeanSerializer<queryBarcodeByExternalCode_result>
		{
			
			public static queryBarcodeByExternalCode_resultHelper OBJ = new queryBarcodeByExternalCode_resultHelper();
			
			public static queryBarcodeByExternalCode_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryBarcodeByExternalCode_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryBarcodeByExternalCode_result structs, Protocol oprot){
				
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
			
			
			public void Validate(queryBarcodeByExternalCode_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class queryBarcodeByRfid_resultHelper : TBeanSerializer<queryBarcodeByRfid_result>
		{
			
			public static queryBarcodeByRfid_resultHelper OBJ = new queryBarcodeByRfid_resultHelper();
			
			public static queryBarcodeByRfid_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryBarcodeByRfid_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryBarcodeByRfid_result structs, Protocol oprot){
				
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
			
			
			public void Validate(queryBarcodeByRfid_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class queryEpcStatus_resultHelper : TBeanSerializer<queryEpcStatus_result>
		{
			
			public static queryEpcStatus_resultHelper OBJ = new queryEpcStatus_resultHelper();
			
			public static queryEpcStatus_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryEpcStatus_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.xstore.cc.rfid.api.RfidEpcStatusResponse value;
					
					value = new vipapis.xstore.cc.rfid.api.RfidEpcStatusResponse();
					vipapis.xstore.cc.rfid.api.RfidEpcStatusResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryEpcStatus_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.xstore.cc.rfid.api.RfidEpcStatusResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryEpcStatus_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class queryRfidSyncResult_resultHelper : TBeanSerializer<queryRfidSyncResult_result>
		{
			
			public static queryRfidSyncResult_resultHelper OBJ = new queryRfidSyncResult_resultHelper();
			
			public static queryRfidSyncResult_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryRfidSyncResult_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<vipapis.xstore.cc.rfid.api.RfidSyncResultResponse> value;
					
					value = new List<vipapis.xstore.cc.rfid.api.RfidSyncResultResponse>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							vipapis.xstore.cc.rfid.api.RfidSyncResultResponse elem0;
							
							elem0 = new vipapis.xstore.cc.rfid.api.RfidSyncResultResponse();
							vipapis.xstore.cc.rfid.api.RfidSyncResultResponseHelper.getInstance().Read(elem0, iprot);
							
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
			
			
			public void Write(queryRfidSyncResult_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(vipapis.xstore.cc.rfid.api.RfidSyncResultResponse _item0 in structs.GetSuccess()){
						
						
						vipapis.xstore.cc.rfid.api.RfidSyncResultResponseHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryRfidSyncResult_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class uploadEpc_resultHelper : TBeanSerializer<uploadEpc_result>
		{
			
			public static uploadEpc_resultHelper OBJ = new uploadEpc_resultHelper();
			
			public static uploadEpc_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(uploadEpc_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					bool? value;
					value = iprot.ReadBool();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(uploadEpc_result structs, Protocol oprot){
				
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
			
			
			public void Validate(uploadEpc_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class RFIDServiceClient : OspRestStub , RFIDService  {
			
			
			public RFIDServiceClient():base("vipapis.xstore.cc.rfid.api.RFIDService","1.0.0") {
				
				
			}
			
			
			
			public vipapis.xstore.cc.rfid.api.RfidDataResponse addRfid2BarcodeMapping(vipapis.xstore.cc.rfid.api.RfidDataRequest request_) {
				
				send_addRfid2BarcodeMapping(request_);
				return recv_addRfid2BarcodeMapping(); 
				
			}
			
			
			private void send_addRfid2BarcodeMapping(vipapis.xstore.cc.rfid.api.RfidDataRequest request_){
				
				InitInvocation("addRfid2BarcodeMapping");
				
				addRfid2BarcodeMapping_args args = new addRfid2BarcodeMapping_args();
				args.SetRequest(request_);
				
				SendBase(args, addRfid2BarcodeMapping_argsHelper.getInstance());
			}
			
			
			private vipapis.xstore.cc.rfid.api.RfidDataResponse recv_addRfid2BarcodeMapping(){
				
				addRfid2BarcodeMapping_result result = new addRfid2BarcodeMapping_result();
				ReceiveBase(result, addRfid2BarcodeMapping_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<vipapis.xstore.cc.rfid.api.RfidDataResponse> batchAddRfid2BarcodeMapping(List<vipapis.xstore.cc.rfid.api.RfidDataRequest> requests_) {
				
				send_batchAddRfid2BarcodeMapping(requests_);
				return recv_batchAddRfid2BarcodeMapping(); 
				
			}
			
			
			private void send_batchAddRfid2BarcodeMapping(List<vipapis.xstore.cc.rfid.api.RfidDataRequest> requests_){
				
				InitInvocation("batchAddRfid2BarcodeMapping");
				
				batchAddRfid2BarcodeMapping_args args = new batchAddRfid2BarcodeMapping_args();
				args.SetRequests(requests_);
				
				SendBase(args, batchAddRfid2BarcodeMapping_argsHelper.getInstance());
			}
			
			
			private List<vipapis.xstore.cc.rfid.api.RfidDataResponse> recv_batchAddRfid2BarcodeMapping(){
				
				batchAddRfid2BarcodeMapping_result result = new batchAddRfid2BarcodeMapping_result();
				ReceiveBase(result, batchAddRfid2BarcodeMapping_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public string generateExternalCode(string barcode_,string owner_,string oldBarcode_) {
				
				send_generateExternalCode(barcode_,owner_,oldBarcode_);
				return recv_generateExternalCode(); 
				
			}
			
			
			private void send_generateExternalCode(string barcode_,string owner_,string oldBarcode_){
				
				InitInvocation("generateExternalCode");
				
				generateExternalCode_args args = new generateExternalCode_args();
				args.SetBarcode(barcode_);
				args.SetOwner(owner_);
				args.SetOldBarcode(oldBarcode_);
				
				SendBase(args, generateExternalCode_argsHelper.getInstance());
			}
			
			
			private string recv_generateExternalCode(){
				
				generateExternalCode_result result = new generateExternalCode_result();
				ReceiveBase(result, generateExternalCode_resultHelper.getInstance());
				
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
			
			
			public string queryBarcodeByExternalCode(string externalCode_,string owner_) {
				
				send_queryBarcodeByExternalCode(externalCode_,owner_);
				return recv_queryBarcodeByExternalCode(); 
				
			}
			
			
			private void send_queryBarcodeByExternalCode(string externalCode_,string owner_){
				
				InitInvocation("queryBarcodeByExternalCode");
				
				queryBarcodeByExternalCode_args args = new queryBarcodeByExternalCode_args();
				args.SetExternalCode(externalCode_);
				args.SetOwner(owner_);
				
				SendBase(args, queryBarcodeByExternalCode_argsHelper.getInstance());
			}
			
			
			private string recv_queryBarcodeByExternalCode(){
				
				queryBarcodeByExternalCode_result result = new queryBarcodeByExternalCode_result();
				ReceiveBase(result, queryBarcodeByExternalCode_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public string queryBarcodeByRfid(string rfid_,string owner_) {
				
				send_queryBarcodeByRfid(rfid_,owner_);
				return recv_queryBarcodeByRfid(); 
				
			}
			
			
			private void send_queryBarcodeByRfid(string rfid_,string owner_){
				
				InitInvocation("queryBarcodeByRfid");
				
				queryBarcodeByRfid_args args = new queryBarcodeByRfid_args();
				args.SetRfid(rfid_);
				args.SetOwner(owner_);
				
				SendBase(args, queryBarcodeByRfid_argsHelper.getInstance());
			}
			
			
			private string recv_queryBarcodeByRfid(){
				
				queryBarcodeByRfid_result result = new queryBarcodeByRfid_result();
				ReceiveBase(result, queryBarcodeByRfid_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public vipapis.xstore.cc.rfid.api.RfidEpcStatusResponse queryEpcStatus(string epc_,string owner_) {
				
				send_queryEpcStatus(epc_,owner_);
				return recv_queryEpcStatus(); 
				
			}
			
			
			private void send_queryEpcStatus(string epc_,string owner_){
				
				InitInvocation("queryEpcStatus");
				
				queryEpcStatus_args args = new queryEpcStatus_args();
				args.SetEpc(epc_);
				args.SetOwner(owner_);
				
				SendBase(args, queryEpcStatus_argsHelper.getInstance());
			}
			
			
			private vipapis.xstore.cc.rfid.api.RfidEpcStatusResponse recv_queryEpcStatus(){
				
				queryEpcStatus_result result = new queryEpcStatus_result();
				ReceiveBase(result, queryEpcStatus_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<vipapis.xstore.cc.rfid.api.RfidSyncResultResponse> queryRfidSyncResult(List<string> barcodes_,string owner_) {
				
				send_queryRfidSyncResult(barcodes_,owner_);
				return recv_queryRfidSyncResult(); 
				
			}
			
			
			private void send_queryRfidSyncResult(List<string> barcodes_,string owner_){
				
				InitInvocation("queryRfidSyncResult");
				
				queryRfidSyncResult_args args = new queryRfidSyncResult_args();
				args.SetBarcodes(barcodes_);
				args.SetOwner(owner_);
				
				SendBase(args, queryRfidSyncResult_argsHelper.getInstance());
			}
			
			
			private List<vipapis.xstore.cc.rfid.api.RfidSyncResultResponse> recv_queryRfidSyncResult(){
				
				queryRfidSyncResult_result result = new queryRfidSyncResult_result();
				ReceiveBase(result, queryRfidSyncResult_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public bool? uploadEpc(vipapis.xstore.cc.rfid.api.RfidEpcParamModel epc_) {
				
				send_uploadEpc(epc_);
				return recv_uploadEpc(); 
				
			}
			
			
			private void send_uploadEpc(vipapis.xstore.cc.rfid.api.RfidEpcParamModel epc_){
				
				InitInvocation("uploadEpc");
				
				uploadEpc_args args = new uploadEpc_args();
				args.SetEpc(epc_);
				
				SendBase(args, uploadEpc_argsHelper.getInstance());
			}
			
			
			private bool? recv_uploadEpc(){
				
				uploadEpc_result result = new uploadEpc_result();
				ReceiveBase(result, uploadEpc_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
		}
		
		
	}
	
}