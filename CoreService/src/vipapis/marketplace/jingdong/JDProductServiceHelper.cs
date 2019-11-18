using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace vipapis.marketplace.jingdong{
	
	
	public class JDProductServiceHelper {
		
		
		
		public class getOrderActive_args {
			
			///<summary>
			/// 请求参数
			///</summary>
			
			private vipapis.marketplace.jingdong.GetOrderActiveRequest request_;
			
			public vipapis.marketplace.jingdong.GetOrderActiveRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(vipapis.marketplace.jingdong.GetOrderActiveRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class getSkuCommission_args {
			
			///<summary>
			/// 商品编号sku_id列表最大50
			///</summary>
			
			private List<string> sku_ids_;
			
			public List<string> GetSku_ids(){
				return this.sku_ids_;
			}
			
			public void SetSku_ids(List<string> value){
				this.sku_ids_ = value;
			}
			
		}
		
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class skuOffShelf_args {
			
			///<summary>
			/// 商品编号sku_id
			///</summary>
			
			private string sku_id_;
			
			public string GetSku_id(){
				return this.sku_id_;
			}
			
			public void SetSku_id(string value){
				this.sku_id_ = value;
			}
			
		}
		
		
		
		
		public class skuOnShelf_args {
			
			///<summary>
			/// 商品编号sku_id
			///</summary>
			
			private string sku_id_;
			
			public string GetSku_id(){
				return this.sku_id_;
			}
			
			public void SetSku_id(string value){
				this.sku_id_ = value;
			}
			
		}
		
		
		
		
		public class getOrderActive_result {
			
			///<summary>
			///</summary>
			
			private List<vipapis.marketplace.jingdong.OrderActive> success_;
			
			public List<vipapis.marketplace.jingdong.OrderActive> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<vipapis.marketplace.jingdong.OrderActive> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getSkuCommission_result {
			
			///<summary>
			///</summary>
			
			private List<vipapis.marketplace.jingdong.SkuCommission> success_;
			
			public List<vipapis.marketplace.jingdong.SkuCommission> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<vipapis.marketplace.jingdong.SkuCommission> value){
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
		
		
		
		
		public class skuOffShelf_result {
			
			///<summary>
			///</summary>
			
			private vipapis.marketplace.jingdong.SkuOffShelfResponse success_;
			
			public vipapis.marketplace.jingdong.SkuOffShelfResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.marketplace.jingdong.SkuOffShelfResponse value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class skuOnShelf_result {
			
			///<summary>
			///</summary>
			
			private vipapis.marketplace.jingdong.SkuOnShelfResponse success_;
			
			public vipapis.marketplace.jingdong.SkuOnShelfResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.marketplace.jingdong.SkuOnShelfResponse value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		
		public class getOrderActive_argsHelper : TBeanSerializer<getOrderActive_args>
		{
			
			public static getOrderActive_argsHelper OBJ = new getOrderActive_argsHelper();
			
			public static getOrderActive_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getOrderActive_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.marketplace.jingdong.GetOrderActiveRequest value;
					
					value = new vipapis.marketplace.jingdong.GetOrderActiveRequest();
					vipapis.marketplace.jingdong.GetOrderActiveRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getOrderActive_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					vipapis.marketplace.jingdong.GetOrderActiveRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("request can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getOrderActive_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getSkuCommission_argsHelper : TBeanSerializer<getSkuCommission_args>
		{
			
			public static getSkuCommission_argsHelper OBJ = new getSkuCommission_argsHelper();
			
			public static getSkuCommission_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getSkuCommission_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<string> value;
					
					value = new List<string>();
					iprot.ReadSetBegin();
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
					
					iprot.ReadSetEnd();
					
					structs.SetSku_ids(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getSkuCommission_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSku_ids() != null) {
					
					oprot.WriteFieldBegin("sku_ids");
					
					oprot.WriteSetBegin();
					foreach(string _item0 in structs.GetSku_ids()){
						
						oprot.WriteString(_item0);
						
					}
					
					oprot.WriteSetEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("sku_ids can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getSkuCommission_args bean){
				
				
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
		
		
		
		
		public class skuOffShelf_argsHelper : TBeanSerializer<skuOffShelf_args>
		{
			
			public static skuOffShelf_argsHelper OBJ = new skuOffShelf_argsHelper();
			
			public static skuOffShelf_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(skuOffShelf_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetSku_id(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(skuOffShelf_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSku_id() != null) {
					
					oprot.WriteFieldBegin("sku_id");
					oprot.WriteString(structs.GetSku_id());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("sku_id can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(skuOffShelf_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class skuOnShelf_argsHelper : TBeanSerializer<skuOnShelf_args>
		{
			
			public static skuOnShelf_argsHelper OBJ = new skuOnShelf_argsHelper();
			
			public static skuOnShelf_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(skuOnShelf_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetSku_id(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(skuOnShelf_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSku_id() != null) {
					
					oprot.WriteFieldBegin("sku_id");
					oprot.WriteString(structs.GetSku_id());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("sku_id can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(skuOnShelf_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getOrderActive_resultHelper : TBeanSerializer<getOrderActive_result>
		{
			
			public static getOrderActive_resultHelper OBJ = new getOrderActive_resultHelper();
			
			public static getOrderActive_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getOrderActive_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<vipapis.marketplace.jingdong.OrderActive> value;
					
					value = new List<vipapis.marketplace.jingdong.OrderActive>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							vipapis.marketplace.jingdong.OrderActive elem0;
							
							elem0 = new vipapis.marketplace.jingdong.OrderActive();
							vipapis.marketplace.jingdong.OrderActiveHelper.getInstance().Read(elem0, iprot);
							
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
			
			
			public void Write(getOrderActive_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(vipapis.marketplace.jingdong.OrderActive _item0 in structs.GetSuccess()){
						
						
						vipapis.marketplace.jingdong.OrderActiveHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getOrderActive_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getSkuCommission_resultHelper : TBeanSerializer<getSkuCommission_result>
		{
			
			public static getSkuCommission_resultHelper OBJ = new getSkuCommission_resultHelper();
			
			public static getSkuCommission_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getSkuCommission_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<vipapis.marketplace.jingdong.SkuCommission> value;
					
					value = new List<vipapis.marketplace.jingdong.SkuCommission>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							vipapis.marketplace.jingdong.SkuCommission elem1;
							
							elem1 = new vipapis.marketplace.jingdong.SkuCommission();
							vipapis.marketplace.jingdong.SkuCommissionHelper.getInstance().Read(elem1, iprot);
							
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
			
			
			public void Write(getSkuCommission_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(vipapis.marketplace.jingdong.SkuCommission _item0 in structs.GetSuccess()){
						
						
						vipapis.marketplace.jingdong.SkuCommissionHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getSkuCommission_result bean){
				
				
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
		
		
		
		
		public class skuOffShelf_resultHelper : TBeanSerializer<skuOffShelf_result>
		{
			
			public static skuOffShelf_resultHelper OBJ = new skuOffShelf_resultHelper();
			
			public static skuOffShelf_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(skuOffShelf_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.marketplace.jingdong.SkuOffShelfResponse value;
					
					value = new vipapis.marketplace.jingdong.SkuOffShelfResponse();
					vipapis.marketplace.jingdong.SkuOffShelfResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(skuOffShelf_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.marketplace.jingdong.SkuOffShelfResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(skuOffShelf_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class skuOnShelf_resultHelper : TBeanSerializer<skuOnShelf_result>
		{
			
			public static skuOnShelf_resultHelper OBJ = new skuOnShelf_resultHelper();
			
			public static skuOnShelf_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(skuOnShelf_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.marketplace.jingdong.SkuOnShelfResponse value;
					
					value = new vipapis.marketplace.jingdong.SkuOnShelfResponse();
					vipapis.marketplace.jingdong.SkuOnShelfResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(skuOnShelf_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.marketplace.jingdong.SkuOnShelfResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(skuOnShelf_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class JDProductServiceClient : OspRestStub , JDProductService  {
			
			
			public JDProductServiceClient():base("vipapis.marketplace.jingdong.JDProductService","1.0.0") {
				
				
			}
			
			
			
			public List<vipapis.marketplace.jingdong.OrderActive> getOrderActive(vipapis.marketplace.jingdong.GetOrderActiveRequest request_) {
				
				send_getOrderActive(request_);
				return recv_getOrderActive(); 
				
			}
			
			
			private void send_getOrderActive(vipapis.marketplace.jingdong.GetOrderActiveRequest request_){
				
				InitInvocation("getOrderActive");
				
				getOrderActive_args args = new getOrderActive_args();
				args.SetRequest(request_);
				
				SendBase(args, getOrderActive_argsHelper.getInstance());
			}
			
			
			private List<vipapis.marketplace.jingdong.OrderActive> recv_getOrderActive(){
				
				getOrderActive_result result = new getOrderActive_result();
				ReceiveBase(result, getOrderActive_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<vipapis.marketplace.jingdong.SkuCommission> getSkuCommission(List<string> sku_ids_) {
				
				send_getSkuCommission(sku_ids_);
				return recv_getSkuCommission(); 
				
			}
			
			
			private void send_getSkuCommission(List<string> sku_ids_){
				
				InitInvocation("getSkuCommission");
				
				getSkuCommission_args args = new getSkuCommission_args();
				args.SetSku_ids(sku_ids_);
				
				SendBase(args, getSkuCommission_argsHelper.getInstance());
			}
			
			
			private List<vipapis.marketplace.jingdong.SkuCommission> recv_getSkuCommission(){
				
				getSkuCommission_result result = new getSkuCommission_result();
				ReceiveBase(result, getSkuCommission_resultHelper.getInstance());
				
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
			
			
			public vipapis.marketplace.jingdong.SkuOffShelfResponse skuOffShelf(string sku_id_) {
				
				send_skuOffShelf(sku_id_);
				return recv_skuOffShelf(); 
				
			}
			
			
			private void send_skuOffShelf(string sku_id_){
				
				InitInvocation("skuOffShelf");
				
				skuOffShelf_args args = new skuOffShelf_args();
				args.SetSku_id(sku_id_);
				
				SendBase(args, skuOffShelf_argsHelper.getInstance());
			}
			
			
			private vipapis.marketplace.jingdong.SkuOffShelfResponse recv_skuOffShelf(){
				
				skuOffShelf_result result = new skuOffShelf_result();
				ReceiveBase(result, skuOffShelf_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public vipapis.marketplace.jingdong.SkuOnShelfResponse skuOnShelf(string sku_id_) {
				
				send_skuOnShelf(sku_id_);
				return recv_skuOnShelf(); 
				
			}
			
			
			private void send_skuOnShelf(string sku_id_){
				
				InitInvocation("skuOnShelf");
				
				skuOnShelf_args args = new skuOnShelf_args();
				args.SetSku_id(sku_id_);
				
				SendBase(args, skuOnShelf_argsHelper.getInstance());
			}
			
			
			private vipapis.marketplace.jingdong.SkuOnShelfResponse recv_skuOnShelf(){
				
				skuOnShelf_result result = new skuOnShelf_result();
				ReceiveBase(result, skuOnShelf_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
		}
		
		
	}
	
}