using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace vipapis.cup.inventory{
	
	
	public class InventoryServiceHelper {
		
		
		
		public class getSkuInventory_args {
			
			///<summary>
			/// 地址码
			///</summary>
			
			private string area_id_;
			
			///<summary>
			/// 商品SkuId列表
			///</summary>
			
			private List<string> pro_sku_id_list_;
			
			public string GetArea_id(){
				return this.area_id_;
			}
			
			public void SetArea_id(string value){
				this.area_id_ = value;
			}
			public List<string> GetPro_sku_id_list(){
				return this.pro_sku_id_list_;
			}
			
			public void SetPro_sku_id_list(List<string> value){
				this.pro_sku_id_list_ = value;
			}
			
		}
		
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class preHoldSkuInventory_args {
			
			///<summary>
			/// 地址码
			///</summary>
			
			private string area_id_;
			
			///<summary>
			/// 第三方订单号
			///</summary>
			
			private string order_sn_;
			
			///<summary>
			/// 商品预占信息列表
			///</summary>
			
			private List<com.vip.vop.cup.api.inventory.ProdSkuInv> prod_sku_inv_list_;
			
			public string GetArea_id(){
				return this.area_id_;
			}
			
			public void SetArea_id(string value){
				this.area_id_ = value;
			}
			public string GetOrder_sn(){
				return this.order_sn_;
			}
			
			public void SetOrder_sn(string value){
				this.order_sn_ = value;
			}
			public List<com.vip.vop.cup.api.inventory.ProdSkuInv> GetProd_sku_inv_list(){
				return this.prod_sku_inv_list_;
			}
			
			public void SetProd_sku_inv_list(List<com.vip.vop.cup.api.inventory.ProdSkuInv> value){
				this.prod_sku_inv_list_ = value;
			}
			
		}
		
		
		
		
		public class releaseSkuInventory_args {
			
			///<summary>
			/// 第三方订单号
			///</summary>
			
			private string order_sn_;
			
			///<summary>
			/// 商品SkuId列表
			///</summary>
			
			private List<string> pro_sku_id_list_;
			
			public string GetOrder_sn(){
				return this.order_sn_;
			}
			
			public void SetOrder_sn(string value){
				this.order_sn_ = value;
			}
			public List<string> GetPro_sku_id_list(){
				return this.pro_sku_id_list_;
			}
			
			public void SetPro_sku_id_list(List<string> value){
				this.pro_sku_id_list_ = value;
			}
			
		}
		
		
		
		
		public class getSkuInventory_result {
			
			///<summary>
			///</summary>
			
			private List<com.vip.vop.cup.api.inventory.ProdSkuInvInfo> success_;
			
			public List<com.vip.vop.cup.api.inventory.ProdSkuInvInfo> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.vop.cup.api.inventory.ProdSkuInvInfo> value){
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
		
		
		
		
		public class preHoldSkuInventory_result {
			
			///<summary>
			///</summary>
			
			private com.vip.vop.cup.api.inventory.InventoryOpResult success_;
			
			public com.vip.vop.cup.api.inventory.InventoryOpResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.vop.cup.api.inventory.InventoryOpResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class releaseSkuInventory_result {
			
			///<summary>
			///</summary>
			
			private com.vip.vop.cup.api.inventory.InventoryOpResult success_;
			
			public com.vip.vop.cup.api.inventory.InventoryOpResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.vop.cup.api.inventory.InventoryOpResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		
		public class getSkuInventory_argsHelper : TBeanSerializer<getSkuInventory_args>
		{
			
			public static getSkuInventory_argsHelper OBJ = new getSkuInventory_argsHelper();
			
			public static getSkuInventory_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getSkuInventory_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetArea_id(value);
				}
				
				
				
				
				
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
					
					structs.SetPro_sku_id_list(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getSkuInventory_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetArea_id() != null) {
					
					oprot.WriteFieldBegin("area_id");
					oprot.WriteString(structs.GetArea_id());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("area_id can not be null!");
				}
				
				
				if(structs.GetPro_sku_id_list() != null) {
					
					oprot.WriteFieldBegin("pro_sku_id_list");
					
					oprot.WriteListBegin();
					foreach(string _item0 in structs.GetPro_sku_id_list()){
						
						oprot.WriteString(_item0);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("pro_sku_id_list can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getSkuInventory_args bean){
				
				
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
		
		
		
		
		public class preHoldSkuInventory_argsHelper : TBeanSerializer<preHoldSkuInventory_args>
		{
			
			public static preHoldSkuInventory_argsHelper OBJ = new preHoldSkuInventory_argsHelper();
			
			public static preHoldSkuInventory_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(preHoldSkuInventory_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetArea_id(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetOrder_sn(value);
				}
				
				
				
				
				
				if(true){
					
					List<com.vip.vop.cup.api.inventory.ProdSkuInv> value;
					
					value = new List<com.vip.vop.cup.api.inventory.ProdSkuInv>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.vop.cup.api.inventory.ProdSkuInv elem1;
							
							elem1 = new com.vip.vop.cup.api.inventory.ProdSkuInv();
							com.vip.vop.cup.api.inventory.ProdSkuInvHelper.getInstance().Read(elem1, iprot);
							
							value.Add(elem1);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetProd_sku_inv_list(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(preHoldSkuInventory_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetArea_id() != null) {
					
					oprot.WriteFieldBegin("area_id");
					oprot.WriteString(structs.GetArea_id());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("area_id can not be null!");
				}
				
				
				if(structs.GetOrder_sn() != null) {
					
					oprot.WriteFieldBegin("order_sn");
					oprot.WriteString(structs.GetOrder_sn());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("order_sn can not be null!");
				}
				
				
				if(structs.GetProd_sku_inv_list() != null) {
					
					oprot.WriteFieldBegin("prod_sku_inv_list");
					
					oprot.WriteListBegin();
					foreach(com.vip.vop.cup.api.inventory.ProdSkuInv _item0 in structs.GetProd_sku_inv_list()){
						
						
						com.vip.vop.cup.api.inventory.ProdSkuInvHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("prod_sku_inv_list can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(preHoldSkuInventory_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class releaseSkuInventory_argsHelper : TBeanSerializer<releaseSkuInventory_args>
		{
			
			public static releaseSkuInventory_argsHelper OBJ = new releaseSkuInventory_argsHelper();
			
			public static releaseSkuInventory_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(releaseSkuInventory_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetOrder_sn(value);
				}
				
				
				
				
				
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
					
					structs.SetPro_sku_id_list(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(releaseSkuInventory_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetOrder_sn() != null) {
					
					oprot.WriteFieldBegin("order_sn");
					oprot.WriteString(structs.GetOrder_sn());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("order_sn can not be null!");
				}
				
				
				if(structs.GetPro_sku_id_list() != null) {
					
					oprot.WriteFieldBegin("pro_sku_id_list");
					
					oprot.WriteListBegin();
					foreach(string _item0 in structs.GetPro_sku_id_list()){
						
						oprot.WriteString(_item0);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("pro_sku_id_list can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(releaseSkuInventory_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getSkuInventory_resultHelper : TBeanSerializer<getSkuInventory_result>
		{
			
			public static getSkuInventory_resultHelper OBJ = new getSkuInventory_resultHelper();
			
			public static getSkuInventory_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getSkuInventory_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.vop.cup.api.inventory.ProdSkuInvInfo> value;
					
					value = new List<com.vip.vop.cup.api.inventory.ProdSkuInvInfo>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.vop.cup.api.inventory.ProdSkuInvInfo elem1;
							
							elem1 = new com.vip.vop.cup.api.inventory.ProdSkuInvInfo();
							com.vip.vop.cup.api.inventory.ProdSkuInvInfoHelper.getInstance().Read(elem1, iprot);
							
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
			
			
			public void Write(getSkuInventory_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.vop.cup.api.inventory.ProdSkuInvInfo _item0 in structs.GetSuccess()){
						
						
						com.vip.vop.cup.api.inventory.ProdSkuInvInfoHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getSkuInventory_result bean){
				
				
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
		
		
		
		
		public class preHoldSkuInventory_resultHelper : TBeanSerializer<preHoldSkuInventory_result>
		{
			
			public static preHoldSkuInventory_resultHelper OBJ = new preHoldSkuInventory_resultHelper();
			
			public static preHoldSkuInventory_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(preHoldSkuInventory_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.cup.api.inventory.InventoryOpResult value;
					
					value = new com.vip.vop.cup.api.inventory.InventoryOpResult();
					com.vip.vop.cup.api.inventory.InventoryOpResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(preHoldSkuInventory_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.vop.cup.api.inventory.InventoryOpResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(preHoldSkuInventory_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class releaseSkuInventory_resultHelper : TBeanSerializer<releaseSkuInventory_result>
		{
			
			public static releaseSkuInventory_resultHelper OBJ = new releaseSkuInventory_resultHelper();
			
			public static releaseSkuInventory_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(releaseSkuInventory_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.cup.api.inventory.InventoryOpResult value;
					
					value = new com.vip.vop.cup.api.inventory.InventoryOpResult();
					com.vip.vop.cup.api.inventory.InventoryOpResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(releaseSkuInventory_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.vop.cup.api.inventory.InventoryOpResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(releaseSkuInventory_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class InventoryServiceClient : OspRestStub , InventoryService  {
			
			
			public InventoryServiceClient():base("vipapis.cup.inventory.InventoryService","1.0.0") {
				
				
			}
			
			
			
			public List<com.vip.vop.cup.api.inventory.ProdSkuInvInfo> getSkuInventory(string area_id_,List<string> pro_sku_id_list_) {
				
				send_getSkuInventory(area_id_,pro_sku_id_list_);
				return recv_getSkuInventory(); 
				
			}
			
			
			private void send_getSkuInventory(string area_id_,List<string> pro_sku_id_list_){
				
				InitInvocation("getSkuInventory");
				
				getSkuInventory_args args = new getSkuInventory_args();
				args.SetArea_id(area_id_);
				args.SetPro_sku_id_list(pro_sku_id_list_);
				
				SendBase(args, getSkuInventory_argsHelper.getInstance());
			}
			
			
			private List<com.vip.vop.cup.api.inventory.ProdSkuInvInfo> recv_getSkuInventory(){
				
				getSkuInventory_result result = new getSkuInventory_result();
				ReceiveBase(result, getSkuInventory_resultHelper.getInstance());
				
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
			
			
			public com.vip.vop.cup.api.inventory.InventoryOpResult preHoldSkuInventory(string area_id_,string order_sn_,List<com.vip.vop.cup.api.inventory.ProdSkuInv> prod_sku_inv_list_) {
				
				send_preHoldSkuInventory(area_id_,order_sn_,prod_sku_inv_list_);
				return recv_preHoldSkuInventory(); 
				
			}
			
			
			private void send_preHoldSkuInventory(string area_id_,string order_sn_,List<com.vip.vop.cup.api.inventory.ProdSkuInv> prod_sku_inv_list_){
				
				InitInvocation("preHoldSkuInventory");
				
				preHoldSkuInventory_args args = new preHoldSkuInventory_args();
				args.SetArea_id(area_id_);
				args.SetOrder_sn(order_sn_);
				args.SetProd_sku_inv_list(prod_sku_inv_list_);
				
				SendBase(args, preHoldSkuInventory_argsHelper.getInstance());
			}
			
			
			private com.vip.vop.cup.api.inventory.InventoryOpResult recv_preHoldSkuInventory(){
				
				preHoldSkuInventory_result result = new preHoldSkuInventory_result();
				ReceiveBase(result, preHoldSkuInventory_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.vop.cup.api.inventory.InventoryOpResult releaseSkuInventory(string order_sn_,List<string> pro_sku_id_list_) {
				
				send_releaseSkuInventory(order_sn_,pro_sku_id_list_);
				return recv_releaseSkuInventory(); 
				
			}
			
			
			private void send_releaseSkuInventory(string order_sn_,List<string> pro_sku_id_list_){
				
				InitInvocation("releaseSkuInventory");
				
				releaseSkuInventory_args args = new releaseSkuInventory_args();
				args.SetOrder_sn(order_sn_);
				args.SetPro_sku_id_list(pro_sku_id_list_);
				
				SendBase(args, releaseSkuInventory_argsHelper.getInstance());
			}
			
			
			private com.vip.vop.cup.api.inventory.InventoryOpResult recv_releaseSkuInventory(){
				
				releaseSkuInventory_result result = new releaseSkuInventory_result();
				ReceiveBase(result, releaseSkuInventory_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
		}
		
		
	}
	
}