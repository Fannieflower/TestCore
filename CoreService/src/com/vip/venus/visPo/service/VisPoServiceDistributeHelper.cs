using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace com.vip.venus.visPo.service{
	
	
	public class VisPoServiceDistributeHelper {
		
		
		
		public class dispatchNoParameter_args {
			
			
		}
		
		
		
		
		public class getPoDataByMaxId_args {
			
			///<summary>
			/// 拉取开始节点
			///</summary>
			
			private long? maxId_;
			
			///<summary>
			/// 步长
			///</summary>
			
			private long? count_;
			
			///<summary>
			/// 仓库编码
			///</summary>
			
			private string warehouseCode_;
			
			public long? GetMaxId(){
				return this.maxId_;
			}
			
			public void SetMaxId(long? value){
				this.maxId_ = value;
			}
			public long? GetCount(){
				return this.count_;
			}
			
			public void SetCount(long? value){
				this.count_ = value;
			}
			public string GetWarehouseCode(){
				return this.warehouseCode_;
			}
			
			public void SetWarehouseCode(string value){
				this.warehouseCode_ = value;
			}
			
		}
		
		
		
		
		public class getPoDetailsWMSByPoNoAndItemNo_args {
			
			///<summary>
			///</summary>
			
			private Dictionary<string, List<string>> queryParams_;
			
			public Dictionary<string, List<string>> GetQueryParams(){
				return this.queryParams_;
			}
			
			public void SetQueryParams(Dictionary<string, List<string>> value){
				this.queryParams_ = value;
			}
			
		}
		
		
		
		
		public class getPoEBSDetailsByPo_args {
			
			///<summary>
			///</summary>
			
			private string po_;
			
			///<summary>
			///</summary>
			
			private int? page_;
			
			///<summary>
			///</summary>
			
			private int? size_;
			
			public string GetPo(){
				return this.po_;
			}
			
			public void SetPo(string value){
				this.po_ = value;
			}
			public int? GetPage(){
				return this.page_;
			}
			
			public void SetPage(int? value){
				this.page_ = value;
			}
			public int? GetSize(){
				return this.size_;
			}
			
			public void SetSize(int? value){
				this.size_ = value;
			}
			
		}
		
		
		
		
		public class getPoEBSDetailsByPoBatchNum_args {
			
			///<summary>
			///</summary>
			
			private string po_;
			
			///<summary>
			///</summary>
			
			private int? batchNum_;
			
			///<summary>
			///</summary>
			
			private int? page_;
			
			///<summary>
			///</summary>
			
			private int? size_;
			
			public string GetPo(){
				return this.po_;
			}
			
			public void SetPo(string value){
				this.po_ = value;
			}
			public int? GetBatchNum(){
				return this.batchNum_;
			}
			
			public void SetBatchNum(int? value){
				this.batchNum_ = value;
			}
			public int? GetPage(){
				return this.page_;
			}
			
			public void SetPage(int? value){
				this.page_ = value;
			}
			public int? GetSize(){
				return this.size_;
			}
			
			public void SetSize(int? value){
				this.size_ = value;
			}
			
		}
		
		
		
		
		public class getPoEBSDetailsByPoSKU_args {
			
			///<summary>
			///</summary>
			
			private string poNum_;
			
			///<summary>
			///</summary>
			
			private string itemNum_;
			
			public string GetPoNum(){
				return this.poNum_;
			}
			
			public void SetPoNum(string value){
				this.poNum_ = value;
			}
			public string GetItemNum(){
				return this.itemNum_;
			}
			
			public void SetItemNum(string value){
				this.itemNum_ = value;
			}
			
		}
		
		
		
		
		public class getPoWMSDetailsByMaxId_args {
			
			///<summary>
			///</summary>
			
			private string maxId_;
			
			///<summary>
			///</summary>
			
			private string saleArea_;
			
			///<summary>
			///</summary>
			
			private int? count_;
			
			public string GetMaxId(){
				return this.maxId_;
			}
			
			public void SetMaxId(string value){
				this.maxId_ = value;
			}
			public string GetSaleArea(){
				return this.saleArea_;
			}
			
			public void SetSaleArea(string value){
				this.saleArea_ = value;
			}
			public int? GetCount(){
				return this.count_;
			}
			
			public void SetCount(int? value){
				this.count_ = value;
			}
			
		}
		
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class dispatchNoParameter_result {
			
			
		}
		
		
		
		
		public class getPoDataByMaxId_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.venus.visPo.service.PoDetailData> success_;
			
			public List<com.vip.venus.visPo.service.PoDetailData> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.venus.visPo.service.PoDetailData> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getPoDetailsWMSByPoNoAndItemNo_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.venus.visPo.service.WMSPoDetail> success_;
			
			public List<com.vip.venus.visPo.service.WMSPoDetail> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.venus.visPo.service.WMSPoDetail> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getPoEBSDetailsByPo_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.venus.visPo.service.EBSPoDetail> success_;
			
			public List<com.vip.venus.visPo.service.EBSPoDetail> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.venus.visPo.service.EBSPoDetail> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getPoEBSDetailsByPoBatchNum_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.venus.visPo.service.EBSPoDetail> success_;
			
			public List<com.vip.venus.visPo.service.EBSPoDetail> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.venus.visPo.service.EBSPoDetail> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getPoEBSDetailsByPoSKU_result {
			
			///<summary>
			///</summary>
			
			private com.vip.venus.visPo.service.EBSPoDetail success_;
			
			public com.vip.venus.visPo.service.EBSPoDetail GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.venus.visPo.service.EBSPoDetail value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getPoWMSDetailsByMaxId_result {
			
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
		
		
		
		
		
		public class dispatchNoParameter_argsHelper : TBeanSerializer<dispatchNoParameter_args>
		{
			
			public static dispatchNoParameter_argsHelper OBJ = new dispatchNoParameter_argsHelper();
			
			public static dispatchNoParameter_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(dispatchNoParameter_args structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(dispatchNoParameter_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(dispatchNoParameter_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getPoDataByMaxId_argsHelper : TBeanSerializer<getPoDataByMaxId_args>
		{
			
			public static getPoDataByMaxId_argsHelper OBJ = new getPoDataByMaxId_argsHelper();
			
			public static getPoDataByMaxId_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getPoDataByMaxId_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					long value;
					value = iprot.ReadI64(); 
					
					structs.SetMaxId(value);
				}
				
				
				
				
				
				if(true){
					
					long value;
					value = iprot.ReadI64(); 
					
					structs.SetCount(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetWarehouseCode(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getPoDataByMaxId_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetMaxId() != null) {
					
					oprot.WriteFieldBegin("maxId");
					oprot.WriteI64((long)structs.GetMaxId()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("maxId can not be null!");
				}
				
				
				if(structs.GetCount() != null) {
					
					oprot.WriteFieldBegin("count");
					oprot.WriteI64((long)structs.GetCount()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("count can not be null!");
				}
				
				
				if(structs.GetWarehouseCode() != null) {
					
					oprot.WriteFieldBegin("warehouseCode");
					oprot.WriteString(structs.GetWarehouseCode());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("warehouseCode can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getPoDataByMaxId_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getPoDetailsWMSByPoNoAndItemNo_argsHelper : TBeanSerializer<getPoDetailsWMSByPoNoAndItemNo_args>
		{
			
			public static getPoDetailsWMSByPoNoAndItemNo_argsHelper OBJ = new getPoDetailsWMSByPoNoAndItemNo_argsHelper();
			
			public static getPoDetailsWMSByPoNoAndItemNo_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getPoDetailsWMSByPoNoAndItemNo_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					Dictionary<string, List<string>> value;
					
					value = new Dictionary<string, List<string>>();
					iprot.ReadMapBegin();
					while(true){
						
						try{
							
							string _key0;
							List<string> _val0;
							_key0 = iprot.ReadString();
							
							
							_val0 = new List<string>();
							iprot.ReadListBegin();
							while(true){
								
								try{
									
									string elem1;
									elem1 = iprot.ReadString();
									
									_val0.Add(elem1);
								}
								catch(Exception e){
									
									
									break;
								}
							}
							
							iprot.ReadListEnd();
							
							value.Add(_key0, _val0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadMapEnd();
					
					structs.SetQueryParams(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getPoDetailsWMSByPoNoAndItemNo_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetQueryParams() != null) {
					
					oprot.WriteFieldBegin("queryParams");
					
					oprot.WriteMapBegin();
					foreach(KeyValuePair< string, List<string> > _ir0 in structs.GetQueryParams()){
						
						string _key0 = _ir0.Key;
						List<string> _value0 = _ir0.Value;
						oprot.WriteString(_key0);
						
						
						oprot.WriteListBegin();
						foreach(string _item1 in _value0){
							
							oprot.WriteString(_item1);
							
						}
						
						oprot.WriteListEnd();
						
					}
					
					oprot.WriteMapEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("queryParams can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getPoDetailsWMSByPoNoAndItemNo_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getPoEBSDetailsByPo_argsHelper : TBeanSerializer<getPoEBSDetailsByPo_args>
		{
			
			public static getPoEBSDetailsByPo_argsHelper OBJ = new getPoEBSDetailsByPo_argsHelper();
			
			public static getPoEBSDetailsByPo_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getPoEBSDetailsByPo_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetPo(value);
				}
				
				
				
				
				
				if(true){
					
					int value;
					value = iprot.ReadI32(); 
					
					structs.SetPage(value);
				}
				
				
				
				
				
				if(true){
					
					int value;
					value = iprot.ReadI32(); 
					
					structs.SetSize(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getPoEBSDetailsByPo_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetPo() != null) {
					
					oprot.WriteFieldBegin("po");
					oprot.WriteString(structs.GetPo());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("po can not be null!");
				}
				
				
				if(structs.GetPage() != null) {
					
					oprot.WriteFieldBegin("page");
					oprot.WriteI32((int)structs.GetPage()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("page can not be null!");
				}
				
				
				if(structs.GetSize() != null) {
					
					oprot.WriteFieldBegin("size");
					oprot.WriteI32((int)structs.GetSize()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("size can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getPoEBSDetailsByPo_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getPoEBSDetailsByPoBatchNum_argsHelper : TBeanSerializer<getPoEBSDetailsByPoBatchNum_args>
		{
			
			public static getPoEBSDetailsByPoBatchNum_argsHelper OBJ = new getPoEBSDetailsByPoBatchNum_argsHelper();
			
			public static getPoEBSDetailsByPoBatchNum_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getPoEBSDetailsByPoBatchNum_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetPo(value);
				}
				
				
				
				
				
				if(true){
					
					int value;
					value = iprot.ReadI32(); 
					
					structs.SetBatchNum(value);
				}
				
				
				
				
				
				if(true){
					
					int value;
					value = iprot.ReadI32(); 
					
					structs.SetPage(value);
				}
				
				
				
				
				
				if(true){
					
					int value;
					value = iprot.ReadI32(); 
					
					structs.SetSize(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getPoEBSDetailsByPoBatchNum_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetPo() != null) {
					
					oprot.WriteFieldBegin("po");
					oprot.WriteString(structs.GetPo());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("po can not be null!");
				}
				
				
				if(structs.GetBatchNum() != null) {
					
					oprot.WriteFieldBegin("batchNum");
					oprot.WriteI32((int)structs.GetBatchNum()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("batchNum can not be null!");
				}
				
				
				if(structs.GetPage() != null) {
					
					oprot.WriteFieldBegin("page");
					oprot.WriteI32((int)structs.GetPage()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("page can not be null!");
				}
				
				
				if(structs.GetSize() != null) {
					
					oprot.WriteFieldBegin("size");
					oprot.WriteI32((int)structs.GetSize()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("size can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getPoEBSDetailsByPoBatchNum_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getPoEBSDetailsByPoSKU_argsHelper : TBeanSerializer<getPoEBSDetailsByPoSKU_args>
		{
			
			public static getPoEBSDetailsByPoSKU_argsHelper OBJ = new getPoEBSDetailsByPoSKU_argsHelper();
			
			public static getPoEBSDetailsByPoSKU_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getPoEBSDetailsByPoSKU_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetPoNum(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetItemNum(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getPoEBSDetailsByPoSKU_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetPoNum() != null) {
					
					oprot.WriteFieldBegin("poNum");
					oprot.WriteString(structs.GetPoNum());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("poNum can not be null!");
				}
				
				
				if(structs.GetItemNum() != null) {
					
					oprot.WriteFieldBegin("itemNum");
					oprot.WriteString(structs.GetItemNum());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("itemNum can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getPoEBSDetailsByPoSKU_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getPoWMSDetailsByMaxId_argsHelper : TBeanSerializer<getPoWMSDetailsByMaxId_args>
		{
			
			public static getPoWMSDetailsByMaxId_argsHelper OBJ = new getPoWMSDetailsByMaxId_argsHelper();
			
			public static getPoWMSDetailsByMaxId_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getPoWMSDetailsByMaxId_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetMaxId(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetSaleArea(value);
				}
				
				
				
				
				
				if(true){
					
					int value;
					value = iprot.ReadI32(); 
					
					structs.SetCount(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getPoWMSDetailsByMaxId_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetMaxId() != null) {
					
					oprot.WriteFieldBegin("maxId");
					oprot.WriteString(structs.GetMaxId());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("maxId can not be null!");
				}
				
				
				if(structs.GetSaleArea() != null) {
					
					oprot.WriteFieldBegin("saleArea");
					oprot.WriteString(structs.GetSaleArea());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("saleArea can not be null!");
				}
				
				
				if(structs.GetCount() != null) {
					
					oprot.WriteFieldBegin("count");
					oprot.WriteI32((int)structs.GetCount()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("count can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getPoWMSDetailsByMaxId_args bean){
				
				
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
		
		
		
		
		public class dispatchNoParameter_resultHelper : TBeanSerializer<dispatchNoParameter_result>
		{
			
			public static dispatchNoParameter_resultHelper OBJ = new dispatchNoParameter_resultHelper();
			
			public static dispatchNoParameter_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(dispatchNoParameter_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(dispatchNoParameter_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(dispatchNoParameter_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getPoDataByMaxId_resultHelper : TBeanSerializer<getPoDataByMaxId_result>
		{
			
			public static getPoDataByMaxId_resultHelper OBJ = new getPoDataByMaxId_resultHelper();
			
			public static getPoDataByMaxId_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getPoDataByMaxId_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.venus.visPo.service.PoDetailData> value;
					
					value = new List<com.vip.venus.visPo.service.PoDetailData>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.venus.visPo.service.PoDetailData elem0;
							
							elem0 = new com.vip.venus.visPo.service.PoDetailData();
							com.vip.venus.visPo.service.PoDetailDataHelper.getInstance().Read(elem0, iprot);
							
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
			
			
			public void Write(getPoDataByMaxId_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.venus.visPo.service.PoDetailData _item0 in structs.GetSuccess()){
						
						
						com.vip.venus.visPo.service.PoDetailDataHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getPoDataByMaxId_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getPoDetailsWMSByPoNoAndItemNo_resultHelper : TBeanSerializer<getPoDetailsWMSByPoNoAndItemNo_result>
		{
			
			public static getPoDetailsWMSByPoNoAndItemNo_resultHelper OBJ = new getPoDetailsWMSByPoNoAndItemNo_resultHelper();
			
			public static getPoDetailsWMSByPoNoAndItemNo_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getPoDetailsWMSByPoNoAndItemNo_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.venus.visPo.service.WMSPoDetail> value;
					
					value = new List<com.vip.venus.visPo.service.WMSPoDetail>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.venus.visPo.service.WMSPoDetail elem1;
							
							elem1 = new com.vip.venus.visPo.service.WMSPoDetail();
							com.vip.venus.visPo.service.WMSPoDetailHelper.getInstance().Read(elem1, iprot);
							
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
			
			
			public void Write(getPoDetailsWMSByPoNoAndItemNo_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.venus.visPo.service.WMSPoDetail _item0 in structs.GetSuccess()){
						
						
						com.vip.venus.visPo.service.WMSPoDetailHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getPoDetailsWMSByPoNoAndItemNo_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getPoEBSDetailsByPo_resultHelper : TBeanSerializer<getPoEBSDetailsByPo_result>
		{
			
			public static getPoEBSDetailsByPo_resultHelper OBJ = new getPoEBSDetailsByPo_resultHelper();
			
			public static getPoEBSDetailsByPo_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getPoEBSDetailsByPo_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.venus.visPo.service.EBSPoDetail> value;
					
					value = new List<com.vip.venus.visPo.service.EBSPoDetail>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.venus.visPo.service.EBSPoDetail elem1;
							
							elem1 = new com.vip.venus.visPo.service.EBSPoDetail();
							com.vip.venus.visPo.service.EBSPoDetailHelper.getInstance().Read(elem1, iprot);
							
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
			
			
			public void Write(getPoEBSDetailsByPo_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.venus.visPo.service.EBSPoDetail _item0 in structs.GetSuccess()){
						
						
						com.vip.venus.visPo.service.EBSPoDetailHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getPoEBSDetailsByPo_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getPoEBSDetailsByPoBatchNum_resultHelper : TBeanSerializer<getPoEBSDetailsByPoBatchNum_result>
		{
			
			public static getPoEBSDetailsByPoBatchNum_resultHelper OBJ = new getPoEBSDetailsByPoBatchNum_resultHelper();
			
			public static getPoEBSDetailsByPoBatchNum_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getPoEBSDetailsByPoBatchNum_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.venus.visPo.service.EBSPoDetail> value;
					
					value = new List<com.vip.venus.visPo.service.EBSPoDetail>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.venus.visPo.service.EBSPoDetail elem1;
							
							elem1 = new com.vip.venus.visPo.service.EBSPoDetail();
							com.vip.venus.visPo.service.EBSPoDetailHelper.getInstance().Read(elem1, iprot);
							
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
			
			
			public void Write(getPoEBSDetailsByPoBatchNum_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.venus.visPo.service.EBSPoDetail _item0 in structs.GetSuccess()){
						
						
						com.vip.venus.visPo.service.EBSPoDetailHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getPoEBSDetailsByPoBatchNum_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getPoEBSDetailsByPoSKU_resultHelper : TBeanSerializer<getPoEBSDetailsByPoSKU_result>
		{
			
			public static getPoEBSDetailsByPoSKU_resultHelper OBJ = new getPoEBSDetailsByPoSKU_resultHelper();
			
			public static getPoEBSDetailsByPoSKU_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getPoEBSDetailsByPoSKU_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.venus.visPo.service.EBSPoDetail value;
					
					value = new com.vip.venus.visPo.service.EBSPoDetail();
					com.vip.venus.visPo.service.EBSPoDetailHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getPoEBSDetailsByPoSKU_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.venus.visPo.service.EBSPoDetailHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getPoEBSDetailsByPoSKU_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getPoWMSDetailsByMaxId_resultHelper : TBeanSerializer<getPoWMSDetailsByMaxId_result>
		{
			
			public static getPoWMSDetailsByMaxId_resultHelper OBJ = new getPoWMSDetailsByMaxId_resultHelper();
			
			public static getPoWMSDetailsByMaxId_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getPoWMSDetailsByMaxId_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getPoWMSDetailsByMaxId_result structs, Protocol oprot){
				
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
			
			
			public void Validate(getPoWMSDetailsByMaxId_result bean){
				
				
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
		
		
		
		
		public class VisPoServiceDistributeClient : OspRestStub , VisPoServiceDistribute  {
			
			
			public VisPoServiceDistributeClient():base("com.vip.venus.visPo.service.VisPoServiceDistribute","1.0.0") {
				
				
			}
			
			
			
			public void dispatchNoParameter() {
				
				send_dispatchNoParameter();
				recv_dispatchNoParameter();
				
			}
			
			
			private void send_dispatchNoParameter(){
				
				InitInvocation("dispatchNoParameter");
				
				dispatchNoParameter_args args = new dispatchNoParameter_args();
				
				SendBase(args, dispatchNoParameter_argsHelper.getInstance());
			}
			
			
			private void recv_dispatchNoParameter(){
				
				dispatchNoParameter_result result = new dispatchNoParameter_result();
				ReceiveBase(result, dispatchNoParameter_resultHelper.getInstance());
				
				
			}
			
			
			public List<com.vip.venus.visPo.service.PoDetailData> getPoDataByMaxId(long maxId_,long count_,string warehouseCode_) {
				
				send_getPoDataByMaxId(maxId_,count_,warehouseCode_);
				return recv_getPoDataByMaxId(); 
				
			}
			
			
			private void send_getPoDataByMaxId(long maxId_,long count_,string warehouseCode_){
				
				InitInvocation("getPoDataByMaxId");
				
				getPoDataByMaxId_args args = new getPoDataByMaxId_args();
				args.SetMaxId(maxId_);
				args.SetCount(count_);
				args.SetWarehouseCode(warehouseCode_);
				
				SendBase(args, getPoDataByMaxId_argsHelper.getInstance());
			}
			
			
			private List<com.vip.venus.visPo.service.PoDetailData> recv_getPoDataByMaxId(){
				
				getPoDataByMaxId_result result = new getPoDataByMaxId_result();
				ReceiveBase(result, getPoDataByMaxId_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<com.vip.venus.visPo.service.WMSPoDetail> getPoDetailsWMSByPoNoAndItemNo(Dictionary<string, List<string>> queryParams_) {
				
				send_getPoDetailsWMSByPoNoAndItemNo(queryParams_);
				return recv_getPoDetailsWMSByPoNoAndItemNo(); 
				
			}
			
			
			private void send_getPoDetailsWMSByPoNoAndItemNo(Dictionary<string, List<string>> queryParams_){
				
				InitInvocation("getPoDetailsWMSByPoNoAndItemNo");
				
				getPoDetailsWMSByPoNoAndItemNo_args args = new getPoDetailsWMSByPoNoAndItemNo_args();
				args.SetQueryParams(queryParams_);
				
				SendBase(args, getPoDetailsWMSByPoNoAndItemNo_argsHelper.getInstance());
			}
			
			
			private List<com.vip.venus.visPo.service.WMSPoDetail> recv_getPoDetailsWMSByPoNoAndItemNo(){
				
				getPoDetailsWMSByPoNoAndItemNo_result result = new getPoDetailsWMSByPoNoAndItemNo_result();
				ReceiveBase(result, getPoDetailsWMSByPoNoAndItemNo_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<com.vip.venus.visPo.service.EBSPoDetail> getPoEBSDetailsByPo(string po_,int page_,int size_) {
				
				send_getPoEBSDetailsByPo(po_,page_,size_);
				return recv_getPoEBSDetailsByPo(); 
				
			}
			
			
			private void send_getPoEBSDetailsByPo(string po_,int page_,int size_){
				
				InitInvocation("getPoEBSDetailsByPo");
				
				getPoEBSDetailsByPo_args args = new getPoEBSDetailsByPo_args();
				args.SetPo(po_);
				args.SetPage(page_);
				args.SetSize(size_);
				
				SendBase(args, getPoEBSDetailsByPo_argsHelper.getInstance());
			}
			
			
			private List<com.vip.venus.visPo.service.EBSPoDetail> recv_getPoEBSDetailsByPo(){
				
				getPoEBSDetailsByPo_result result = new getPoEBSDetailsByPo_result();
				ReceiveBase(result, getPoEBSDetailsByPo_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<com.vip.venus.visPo.service.EBSPoDetail> getPoEBSDetailsByPoBatchNum(string po_,int batchNum_,int page_,int size_) {
				
				send_getPoEBSDetailsByPoBatchNum(po_,batchNum_,page_,size_);
				return recv_getPoEBSDetailsByPoBatchNum(); 
				
			}
			
			
			private void send_getPoEBSDetailsByPoBatchNum(string po_,int batchNum_,int page_,int size_){
				
				InitInvocation("getPoEBSDetailsByPoBatchNum");
				
				getPoEBSDetailsByPoBatchNum_args args = new getPoEBSDetailsByPoBatchNum_args();
				args.SetPo(po_);
				args.SetBatchNum(batchNum_);
				args.SetPage(page_);
				args.SetSize(size_);
				
				SendBase(args, getPoEBSDetailsByPoBatchNum_argsHelper.getInstance());
			}
			
			
			private List<com.vip.venus.visPo.service.EBSPoDetail> recv_getPoEBSDetailsByPoBatchNum(){
				
				getPoEBSDetailsByPoBatchNum_result result = new getPoEBSDetailsByPoBatchNum_result();
				ReceiveBase(result, getPoEBSDetailsByPoBatchNum_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.venus.visPo.service.EBSPoDetail getPoEBSDetailsByPoSKU(string poNum_,string itemNum_) {
				
				send_getPoEBSDetailsByPoSKU(poNum_,itemNum_);
				return recv_getPoEBSDetailsByPoSKU(); 
				
			}
			
			
			private void send_getPoEBSDetailsByPoSKU(string poNum_,string itemNum_){
				
				InitInvocation("getPoEBSDetailsByPoSKU");
				
				getPoEBSDetailsByPoSKU_args args = new getPoEBSDetailsByPoSKU_args();
				args.SetPoNum(poNum_);
				args.SetItemNum(itemNum_);
				
				SendBase(args, getPoEBSDetailsByPoSKU_argsHelper.getInstance());
			}
			
			
			private com.vip.venus.visPo.service.EBSPoDetail recv_getPoEBSDetailsByPoSKU(){
				
				getPoEBSDetailsByPoSKU_result result = new getPoEBSDetailsByPoSKU_result();
				ReceiveBase(result, getPoEBSDetailsByPoSKU_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public string getPoWMSDetailsByMaxId(string maxId_,string saleArea_,int count_) {
				
				send_getPoWMSDetailsByMaxId(maxId_,saleArea_,count_);
				return recv_getPoWMSDetailsByMaxId(); 
				
			}
			
			
			private void send_getPoWMSDetailsByMaxId(string maxId_,string saleArea_,int count_){
				
				InitInvocation("getPoWMSDetailsByMaxId");
				
				getPoWMSDetailsByMaxId_args args = new getPoWMSDetailsByMaxId_args();
				args.SetMaxId(maxId_);
				args.SetSaleArea(saleArea_);
				args.SetCount(count_);
				
				SendBase(args, getPoWMSDetailsByMaxId_argsHelper.getInstance());
			}
			
			
			private string recv_getPoWMSDetailsByMaxId(){
				
				getPoWMSDetailsByMaxId_result result = new getPoWMSDetailsByMaxId_result();
				ReceiveBase(result, getPoWMSDetailsByMaxId_resultHelper.getInstance());
				
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