using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace vipapis.cup.product{
	
	
	public class ProductServiceHelper {
		
		
		
		public class confirmProductAlteration_args {
			
			///<summary>
			/// 消息id列表，最大50
			///</summary>
			
			private List<long?> message_ids_;
			
			public List<long?> GetMessage_ids(){
				return this.message_ids_;
			}
			
			public void SetMessage_ids(List<long?> value){
				this.message_ids_ = value;
			}
			
		}
		
		
		
		
		public class getProdCategory_args {
			
			///<summary>
			/// 品类ID，不为空时返回指定类目节点下的类目信息，包括子节点信息；为空时返回所有一级类目
			///</summary>
			
			private string category_id_;
			
			public string GetCategory_id(){
				return this.category_id_;
			}
			
			public void SetCategory_id(string value){
				this.category_id_ = value;
			}
			
		}
		
		
		
		
		public class getProdSpuIdList_args {
			
			///<summary>
			/// 页码，默认1
			///</summary>
			
			private int? page_;
			
			///<summary>
			/// 每页大小，默认50，最大200
			///</summary>
			
			private int? page_size_;
			
			///<summary>
			/// 选品开始时间，格式为'yyyy-MM-dd HH:mm:ss'
			///</summary>
			
			private string create_start_time_;
			
			///<summary>
			/// 选品结束时间，格式为'yyyy-MM-dd HH:mm:ss'
			///</summary>
			
			private string create_end_time_;
			
			public int? GetPage(){
				return this.page_;
			}
			
			public void SetPage(int? value){
				this.page_ = value;
			}
			public int? GetPage_size(){
				return this.page_size_;
			}
			
			public void SetPage_size(int? value){
				this.page_size_ = value;
			}
			public string GetCreate_start_time(){
				return this.create_start_time_;
			}
			
			public void SetCreate_start_time(string value){
				this.create_start_time_ = value;
			}
			public string GetCreate_end_time(){
				return this.create_end_time_;
			}
			
			public void SetCreate_end_time(string value){
				this.create_end_time_ = value;
			}
			
		}
		
		
		
		
		public class getSkuDetail_args {
			
			///<summary>
			/// prodSkuId
			///</summary>
			
			private string prod_sku_id_;
			
			public string GetProd_sku_id(){
				return this.prod_sku_id_;
			}
			
			public void SetProd_sku_id(string value){
				this.prod_sku_id_ = value;
			}
			
		}
		
		
		
		
		public class getSkuSalePrice_args {
			
			///<summary>
			/// 商品SkuId
			///</summary>
			
			private string prod_sku_id_;
			
			///<summary>
			/// 价格有效时间点,取有效价格接口无需传递该时间，保留null值即可。取历史价格接口请传递时间点
			///</summary>
			
			private System.DateTime? effective_time_;
			
			public string GetProd_sku_id(){
				return this.prod_sku_id_;
			}
			
			public void SetProd_sku_id(string value){
				this.prod_sku_id_ = value;
			}
			public System.DateTime? GetEffective_time(){
				return this.effective_time_;
			}
			
			public void SetEffective_time(System.DateTime? value){
				this.effective_time_ = value;
			}
			
		}
		
		
		
		
		public class getSpuDetail_args {
			
			///<summary>
			/// prodSpuId
			///</summary>
			
			private string prod_spu_id_;
			
			public string GetProd_spu_id(){
				return this.prod_spu_id_;
			}
			
			public void SetProd_spu_id(string value){
				this.prod_spu_id_ = value;
			}
			
		}
		
		
		
		
		public class getSpuInfoListByProdSpuIds_args {
			
			///<summary>
			/// prodSpuId列表
			///</summary>
			
			private List<string> prod_spu_ids_;
			
			public List<string> GetProd_spu_ids(){
				return this.prod_spu_ids_;
			}
			
			public void SetProd_spu_ids(List<string> value){
				this.prod_spu_ids_ = value;
			}
			
		}
		
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class pullProductAlteration_args {
			
			
		}
		
		
		
		
		public class confirmProductAlteration_result {
			
			///<summary>
			///</summary>
			
			private Dictionary<long?, com.vip.vop.cup.api.product.ConfirmProductAlterationResult> success_;
			
			public Dictionary<long?, com.vip.vop.cup.api.product.ConfirmProductAlterationResult> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(Dictionary<long?, com.vip.vop.cup.api.product.ConfirmProductAlterationResult> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getProdCategory_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.vop.cup.api.product.Category> success_;
			
			public List<com.vip.vop.cup.api.product.Category> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.vop.cup.api.product.Category> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getProdSpuIdList_result {
			
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
		
		
		
		
		public class getSkuDetail_result {
			
			///<summary>
			///</summary>
			
			private com.vip.vop.cup.api.product.SkuDetail success_;
			
			public com.vip.vop.cup.api.product.SkuDetail GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.vop.cup.api.product.SkuDetail value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getSkuSalePrice_result {
			
			///<summary>
			///</summary>
			
			private com.vip.vop.cup.api.product.SkuSalePrice success_;
			
			public com.vip.vop.cup.api.product.SkuSalePrice GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.vop.cup.api.product.SkuSalePrice value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getSpuDetail_result {
			
			///<summary>
			///</summary>
			
			private com.vip.vop.cup.api.product.SpuDetail success_;
			
			public com.vip.vop.cup.api.product.SpuDetail GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.vop.cup.api.product.SpuDetail value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getSpuInfoListByProdSpuIds_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.vop.cup.api.product.Spu> success_;
			
			public List<com.vip.vop.cup.api.product.Spu> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.vop.cup.api.product.Spu> value){
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
		
		
		
		
		public class pullProductAlteration_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.vop.cup.api.product.ProductAlteration> success_;
			
			public List<com.vip.vop.cup.api.product.ProductAlteration> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.vop.cup.api.product.ProductAlteration> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		
		public class confirmProductAlteration_argsHelper : TBeanSerializer<confirmProductAlteration_args>
		{
			
			public static confirmProductAlteration_argsHelper OBJ = new confirmProductAlteration_argsHelper();
			
			public static confirmProductAlteration_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(confirmProductAlteration_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<long?> value;
					
					value = new List<long?>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							long elem1;
							elem1 = iprot.ReadI64(); 
							
							value.Add(elem1);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetMessage_ids(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(confirmProductAlteration_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetMessage_ids() != null) {
					
					oprot.WriteFieldBegin("message_ids");
					
					oprot.WriteListBegin();
					foreach(long _item0 in structs.GetMessage_ids()){
						
						oprot.WriteI64((long)_item0); 
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("message_ids can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(confirmProductAlteration_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getProdCategory_argsHelper : TBeanSerializer<getProdCategory_args>
		{
			
			public static getProdCategory_argsHelper OBJ = new getProdCategory_argsHelper();
			
			public static getProdCategory_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getProdCategory_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetCategory_id(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getProdCategory_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetCategory_id() != null) {
					
					oprot.WriteFieldBegin("category_id");
					oprot.WriteString(structs.GetCategory_id());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getProdCategory_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getProdSpuIdList_argsHelper : TBeanSerializer<getProdSpuIdList_args>
		{
			
			public static getProdSpuIdList_argsHelper OBJ = new getProdSpuIdList_argsHelper();
			
			public static getProdSpuIdList_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getProdSpuIdList_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					int? value;
					value = iprot.ReadI32(); 
					
					structs.SetPage(value);
				}
				
				
				
				
				
				if(true){
					
					int? value;
					value = iprot.ReadI32(); 
					
					structs.SetPage_size(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetCreate_start_time(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetCreate_end_time(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getProdSpuIdList_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetPage() != null) {
					
					oprot.WriteFieldBegin("page");
					oprot.WriteI32((int)structs.GetPage()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetPage_size() != null) {
					
					oprot.WriteFieldBegin("page_size");
					oprot.WriteI32((int)structs.GetPage_size()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetCreate_start_time() != null) {
					
					oprot.WriteFieldBegin("create_start_time");
					oprot.WriteString(structs.GetCreate_start_time());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetCreate_end_time() != null) {
					
					oprot.WriteFieldBegin("create_end_time");
					oprot.WriteString(structs.GetCreate_end_time());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getProdSpuIdList_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getSkuDetail_argsHelper : TBeanSerializer<getSkuDetail_args>
		{
			
			public static getSkuDetail_argsHelper OBJ = new getSkuDetail_argsHelper();
			
			public static getSkuDetail_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getSkuDetail_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetProd_sku_id(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getSkuDetail_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetProd_sku_id() != null) {
					
					oprot.WriteFieldBegin("prod_sku_id");
					oprot.WriteString(structs.GetProd_sku_id());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("prod_sku_id can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getSkuDetail_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getSkuSalePrice_argsHelper : TBeanSerializer<getSkuSalePrice_args>
		{
			
			public static getSkuSalePrice_argsHelper OBJ = new getSkuSalePrice_argsHelper();
			
			public static getSkuSalePrice_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getSkuSalePrice_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetProd_sku_id(value);
				}
				
				
				
				
				
				if(true){
					
					System.DateTime? value;
					value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
					
					structs.SetEffective_time(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getSkuSalePrice_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetProd_sku_id() != null) {
					
					oprot.WriteFieldBegin("prod_sku_id");
					oprot.WriteString(structs.GetProd_sku_id());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("prod_sku_id can not be null!");
				}
				
				
				if(structs.GetEffective_time() != null) {
					
					oprot.WriteFieldBegin("effective_time");
					oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetEffective_time())); 
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getSkuSalePrice_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getSpuDetail_argsHelper : TBeanSerializer<getSpuDetail_args>
		{
			
			public static getSpuDetail_argsHelper OBJ = new getSpuDetail_argsHelper();
			
			public static getSpuDetail_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getSpuDetail_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetProd_spu_id(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getSpuDetail_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetProd_spu_id() != null) {
					
					oprot.WriteFieldBegin("prod_spu_id");
					oprot.WriteString(structs.GetProd_spu_id());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("prod_spu_id can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getSpuDetail_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getSpuInfoListByProdSpuIds_argsHelper : TBeanSerializer<getSpuInfoListByProdSpuIds_args>
		{
			
			public static getSpuInfoListByProdSpuIds_argsHelper OBJ = new getSpuInfoListByProdSpuIds_argsHelper();
			
			public static getSpuInfoListByProdSpuIds_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getSpuInfoListByProdSpuIds_args structs, Protocol iprot){
				
				
				
				
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
					
					structs.SetProd_spu_ids(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getSpuInfoListByProdSpuIds_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetProd_spu_ids() != null) {
					
					oprot.WriteFieldBegin("prod_spu_ids");
					
					oprot.WriteListBegin();
					foreach(string _item0 in structs.GetProd_spu_ids()){
						
						oprot.WriteString(_item0);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("prod_spu_ids can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getSpuInfoListByProdSpuIds_args bean){
				
				
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
		
		
		
		
		public class pullProductAlteration_argsHelper : TBeanSerializer<pullProductAlteration_args>
		{
			
			public static pullProductAlteration_argsHelper OBJ = new pullProductAlteration_argsHelper();
			
			public static pullProductAlteration_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(pullProductAlteration_args structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(pullProductAlteration_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(pullProductAlteration_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class confirmProductAlteration_resultHelper : TBeanSerializer<confirmProductAlteration_result>
		{
			
			public static confirmProductAlteration_resultHelper OBJ = new confirmProductAlteration_resultHelper();
			
			public static confirmProductAlteration_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(confirmProductAlteration_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					Dictionary<long?, com.vip.vop.cup.api.product.ConfirmProductAlterationResult> value;
					
					value = new Dictionary<long?, com.vip.vop.cup.api.product.ConfirmProductAlterationResult>();
					iprot.ReadMapBegin();
					while(true){
						
						try{
							
							long _key1;
							com.vip.vop.cup.api.product.ConfirmProductAlterationResult _val1;
							_key1 = iprot.ReadI64(); 
							
							
							_val1 = new com.vip.vop.cup.api.product.ConfirmProductAlterationResult();
							com.vip.vop.cup.api.product.ConfirmProductAlterationResultHelper.getInstance().Read(_val1, iprot);
							
							value.Add(_key1, _val1);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadMapEnd();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(confirmProductAlteration_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteMapBegin();
					foreach(KeyValuePair< long?, com.vip.vop.cup.api.product.ConfirmProductAlterationResult > _ir0 in structs.GetSuccess()){
						
						long? _key0 = _ir0.Key;
						com.vip.vop.cup.api.product.ConfirmProductAlterationResult _value0 = _ir0.Value;
						oprot.WriteI64((long)_key0); 
						
						
						com.vip.vop.cup.api.product.ConfirmProductAlterationResultHelper.getInstance().Write(_value0, oprot);
						
					}
					
					oprot.WriteMapEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(confirmProductAlteration_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getProdCategory_resultHelper : TBeanSerializer<getProdCategory_result>
		{
			
			public static getProdCategory_resultHelper OBJ = new getProdCategory_resultHelper();
			
			public static getProdCategory_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getProdCategory_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.vop.cup.api.product.Category> value;
					
					value = new List<com.vip.vop.cup.api.product.Category>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.vop.cup.api.product.Category elem1;
							
							elem1 = new com.vip.vop.cup.api.product.Category();
							com.vip.vop.cup.api.product.CategoryHelper.getInstance().Read(elem1, iprot);
							
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
			
			
			public void Write(getProdCategory_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.vop.cup.api.product.Category _item0 in structs.GetSuccess()){
						
						
						com.vip.vop.cup.api.product.CategoryHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getProdCategory_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getProdSpuIdList_resultHelper : TBeanSerializer<getProdSpuIdList_result>
		{
			
			public static getProdSpuIdList_resultHelper OBJ = new getProdSpuIdList_resultHelper();
			
			public static getProdSpuIdList_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getProdSpuIdList_result structs, Protocol iprot){
				
				
				
				
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
			
			
			public void Write(getProdSpuIdList_result structs, Protocol oprot){
				
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
			
			
			public void Validate(getProdSpuIdList_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getSkuDetail_resultHelper : TBeanSerializer<getSkuDetail_result>
		{
			
			public static getSkuDetail_resultHelper OBJ = new getSkuDetail_resultHelper();
			
			public static getSkuDetail_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getSkuDetail_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.cup.api.product.SkuDetail value;
					
					value = new com.vip.vop.cup.api.product.SkuDetail();
					com.vip.vop.cup.api.product.SkuDetailHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getSkuDetail_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.vop.cup.api.product.SkuDetailHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getSkuDetail_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getSkuSalePrice_resultHelper : TBeanSerializer<getSkuSalePrice_result>
		{
			
			public static getSkuSalePrice_resultHelper OBJ = new getSkuSalePrice_resultHelper();
			
			public static getSkuSalePrice_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getSkuSalePrice_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.cup.api.product.SkuSalePrice value;
					
					value = new com.vip.vop.cup.api.product.SkuSalePrice();
					com.vip.vop.cup.api.product.SkuSalePriceHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getSkuSalePrice_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.vop.cup.api.product.SkuSalePriceHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getSkuSalePrice_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getSpuDetail_resultHelper : TBeanSerializer<getSpuDetail_result>
		{
			
			public static getSpuDetail_resultHelper OBJ = new getSpuDetail_resultHelper();
			
			public static getSpuDetail_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getSpuDetail_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.cup.api.product.SpuDetail value;
					
					value = new com.vip.vop.cup.api.product.SpuDetail();
					com.vip.vop.cup.api.product.SpuDetailHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getSpuDetail_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.vop.cup.api.product.SpuDetailHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getSpuDetail_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getSpuInfoListByProdSpuIds_resultHelper : TBeanSerializer<getSpuInfoListByProdSpuIds_result>
		{
			
			public static getSpuInfoListByProdSpuIds_resultHelper OBJ = new getSpuInfoListByProdSpuIds_resultHelper();
			
			public static getSpuInfoListByProdSpuIds_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getSpuInfoListByProdSpuIds_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.vop.cup.api.product.Spu> value;
					
					value = new List<com.vip.vop.cup.api.product.Spu>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.vop.cup.api.product.Spu elem0;
							
							elem0 = new com.vip.vop.cup.api.product.Spu();
							com.vip.vop.cup.api.product.SpuHelper.getInstance().Read(elem0, iprot);
							
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
			
			
			public void Write(getSpuInfoListByProdSpuIds_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.vop.cup.api.product.Spu _item0 in structs.GetSuccess()){
						
						
						com.vip.vop.cup.api.product.SpuHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getSpuInfoListByProdSpuIds_result bean){
				
				
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
		
		
		
		
		public class pullProductAlteration_resultHelper : TBeanSerializer<pullProductAlteration_result>
		{
			
			public static pullProductAlteration_resultHelper OBJ = new pullProductAlteration_resultHelper();
			
			public static pullProductAlteration_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(pullProductAlteration_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.vop.cup.api.product.ProductAlteration> value;
					
					value = new List<com.vip.vop.cup.api.product.ProductAlteration>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.vop.cup.api.product.ProductAlteration elem0;
							
							elem0 = new com.vip.vop.cup.api.product.ProductAlteration();
							com.vip.vop.cup.api.product.ProductAlterationHelper.getInstance().Read(elem0, iprot);
							
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
			
			
			public void Write(pullProductAlteration_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.vop.cup.api.product.ProductAlteration _item0 in structs.GetSuccess()){
						
						
						com.vip.vop.cup.api.product.ProductAlterationHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(pullProductAlteration_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class ProductServiceClient : OspRestStub , ProductService  {
			
			
			public ProductServiceClient():base("vipapis.cup.product.ProductService","1.0.0") {
				
				
			}
			
			
			
			public Dictionary<long?, com.vip.vop.cup.api.product.ConfirmProductAlterationResult> confirmProductAlteration(List<long?> message_ids_) {
				
				send_confirmProductAlteration(message_ids_);
				return recv_confirmProductAlteration(); 
				
			}
			
			
			private void send_confirmProductAlteration(List<long?> message_ids_){
				
				InitInvocation("confirmProductAlteration");
				
				confirmProductAlteration_args args = new confirmProductAlteration_args();
				args.SetMessage_ids(message_ids_);
				
				SendBase(args, confirmProductAlteration_argsHelper.getInstance());
			}
			
			
			private Dictionary<long?, com.vip.vop.cup.api.product.ConfirmProductAlterationResult> recv_confirmProductAlteration(){
				
				confirmProductAlteration_result result = new confirmProductAlteration_result();
				ReceiveBase(result, confirmProductAlteration_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<com.vip.vop.cup.api.product.Category> getProdCategory(string category_id_) {
				
				send_getProdCategory(category_id_);
				return recv_getProdCategory(); 
				
			}
			
			
			private void send_getProdCategory(string category_id_){
				
				InitInvocation("getProdCategory");
				
				getProdCategory_args args = new getProdCategory_args();
				args.SetCategory_id(category_id_);
				
				SendBase(args, getProdCategory_argsHelper.getInstance());
			}
			
			
			private List<com.vip.vop.cup.api.product.Category> recv_getProdCategory(){
				
				getProdCategory_result result = new getProdCategory_result();
				ReceiveBase(result, getProdCategory_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<string> getProdSpuIdList(int? page_,int? page_size_,string create_start_time_,string create_end_time_) {
				
				send_getProdSpuIdList(page_,page_size_,create_start_time_,create_end_time_);
				return recv_getProdSpuIdList(); 
				
			}
			
			
			private void send_getProdSpuIdList(int? page_,int? page_size_,string create_start_time_,string create_end_time_){
				
				InitInvocation("getProdSpuIdList");
				
				getProdSpuIdList_args args = new getProdSpuIdList_args();
				args.SetPage(page_);
				args.SetPage_size(page_size_);
				args.SetCreate_start_time(create_start_time_);
				args.SetCreate_end_time(create_end_time_);
				
				SendBase(args, getProdSpuIdList_argsHelper.getInstance());
			}
			
			
			private List<string> recv_getProdSpuIdList(){
				
				getProdSpuIdList_result result = new getProdSpuIdList_result();
				ReceiveBase(result, getProdSpuIdList_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.vop.cup.api.product.SkuDetail getSkuDetail(string prod_sku_id_) {
				
				send_getSkuDetail(prod_sku_id_);
				return recv_getSkuDetail(); 
				
			}
			
			
			private void send_getSkuDetail(string prod_sku_id_){
				
				InitInvocation("getSkuDetail");
				
				getSkuDetail_args args = new getSkuDetail_args();
				args.SetProd_sku_id(prod_sku_id_);
				
				SendBase(args, getSkuDetail_argsHelper.getInstance());
			}
			
			
			private com.vip.vop.cup.api.product.SkuDetail recv_getSkuDetail(){
				
				getSkuDetail_result result = new getSkuDetail_result();
				ReceiveBase(result, getSkuDetail_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.vop.cup.api.product.SkuSalePrice getSkuSalePrice(string prod_sku_id_,System.DateTime? effective_time_) {
				
				send_getSkuSalePrice(prod_sku_id_,effective_time_);
				return recv_getSkuSalePrice(); 
				
			}
			
			
			private void send_getSkuSalePrice(string prod_sku_id_,System.DateTime? effective_time_){
				
				InitInvocation("getSkuSalePrice");
				
				getSkuSalePrice_args args = new getSkuSalePrice_args();
				args.SetProd_sku_id(prod_sku_id_);
				args.SetEffective_time(effective_time_);
				
				SendBase(args, getSkuSalePrice_argsHelper.getInstance());
			}
			
			
			private com.vip.vop.cup.api.product.SkuSalePrice recv_getSkuSalePrice(){
				
				getSkuSalePrice_result result = new getSkuSalePrice_result();
				ReceiveBase(result, getSkuSalePrice_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.vop.cup.api.product.SpuDetail getSpuDetail(string prod_spu_id_) {
				
				send_getSpuDetail(prod_spu_id_);
				return recv_getSpuDetail(); 
				
			}
			
			
			private void send_getSpuDetail(string prod_spu_id_){
				
				InitInvocation("getSpuDetail");
				
				getSpuDetail_args args = new getSpuDetail_args();
				args.SetProd_spu_id(prod_spu_id_);
				
				SendBase(args, getSpuDetail_argsHelper.getInstance());
			}
			
			
			private com.vip.vop.cup.api.product.SpuDetail recv_getSpuDetail(){
				
				getSpuDetail_result result = new getSpuDetail_result();
				ReceiveBase(result, getSpuDetail_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<com.vip.vop.cup.api.product.Spu> getSpuInfoListByProdSpuIds(List<string> prod_spu_ids_) {
				
				send_getSpuInfoListByProdSpuIds(prod_spu_ids_);
				return recv_getSpuInfoListByProdSpuIds(); 
				
			}
			
			
			private void send_getSpuInfoListByProdSpuIds(List<string> prod_spu_ids_){
				
				InitInvocation("getSpuInfoListByProdSpuIds");
				
				getSpuInfoListByProdSpuIds_args args = new getSpuInfoListByProdSpuIds_args();
				args.SetProd_spu_ids(prod_spu_ids_);
				
				SendBase(args, getSpuInfoListByProdSpuIds_argsHelper.getInstance());
			}
			
			
			private List<com.vip.vop.cup.api.product.Spu> recv_getSpuInfoListByProdSpuIds(){
				
				getSpuInfoListByProdSpuIds_result result = new getSpuInfoListByProdSpuIds_result();
				ReceiveBase(result, getSpuInfoListByProdSpuIds_resultHelper.getInstance());
				
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
			
			
			public List<com.vip.vop.cup.api.product.ProductAlteration> pullProductAlteration() {
				
				send_pullProductAlteration();
				return recv_pullProductAlteration(); 
				
			}
			
			
			private void send_pullProductAlteration(){
				
				InitInvocation("pullProductAlteration");
				
				pullProductAlteration_args args = new pullProductAlteration_args();
				
				SendBase(args, pullProductAlteration_argsHelper.getInstance());
			}
			
			
			private List<com.vip.vop.cup.api.product.ProductAlteration> recv_pullProductAlteration(){
				
				pullProductAlteration_result result = new pullProductAlteration_result();
				ReceiveBase(result, pullProductAlteration_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
		}
		
		
	}
	
}