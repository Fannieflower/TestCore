using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace com.vip.xstore.cc.product.pool.service{
	
	
	public class ProductPurchaseServiceHelper {
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class prodQuery_args {
			
			///<summary>
			/// 待查询商品信息
			///</summary>
			
			private com.vip.xstore.cc.product.pool.service.ProdQueryReqDTO prodQueryReqDTO_;
			
			public com.vip.xstore.cc.product.pool.service.ProdQueryReqDTO GetProdQueryReqDTO(){
				return this.prodQueryReqDTO_;
			}
			
			public void SetProdQueryReqDTO(com.vip.xstore.cc.product.pool.service.ProdQueryReqDTO value){
				this.prodQueryReqDTO_ = value;
			}
			
		}
		
		
		
		
		public class prodValidate_args {
			
			///<summary>
			/// 待校验商品信息
			///</summary>
			
			private com.vip.xstore.cc.product.pool.service.ProdValidateReqDTO prodValidateReqDTO_;
			
			public com.vip.xstore.cc.product.pool.service.ProdValidateReqDTO GetProdValidateReqDTO(){
				return this.prodValidateReqDTO_;
			}
			
			public void SetProdValidateReqDTO(com.vip.xstore.cc.product.pool.service.ProdValidateReqDTO value){
				this.prodValidateReqDTO_ = value;
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
		
		
		
		
		public class prodQuery_result {
			
			///<summary>
			///</summary>
			
			private com.vip.xstore.cc.product.pool.service.ProdQueryRespDTO success_;
			
			public com.vip.xstore.cc.product.pool.service.ProdQueryRespDTO GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.xstore.cc.product.pool.service.ProdQueryRespDTO value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class prodValidate_result {
			
			///<summary>
			///</summary>
			
			private com.vip.xstore.cc.product.pool.service.ProdValidateRespDTO success_;
			
			public com.vip.xstore.cc.product.pool.service.ProdValidateRespDTO GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.xstore.cc.product.pool.service.ProdValidateRespDTO value){
				this.success_ = value;
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
		
		
		
		
		public class prodQuery_argsHelper : TBeanSerializer<prodQuery_args>
		{
			
			public static prodQuery_argsHelper OBJ = new prodQuery_argsHelper();
			
			public static prodQuery_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(prodQuery_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.xstore.cc.product.pool.service.ProdQueryReqDTO value;
					
					value = new com.vip.xstore.cc.product.pool.service.ProdQueryReqDTO();
					com.vip.xstore.cc.product.pool.service.ProdQueryReqDTOHelper.getInstance().Read(value, iprot);
					
					structs.SetProdQueryReqDTO(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(prodQuery_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetProdQueryReqDTO() != null) {
					
					oprot.WriteFieldBegin("prodQueryReqDTO");
					
					com.vip.xstore.cc.product.pool.service.ProdQueryReqDTOHelper.getInstance().Write(structs.GetProdQueryReqDTO(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("prodQueryReqDTO can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(prodQuery_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class prodValidate_argsHelper : TBeanSerializer<prodValidate_args>
		{
			
			public static prodValidate_argsHelper OBJ = new prodValidate_argsHelper();
			
			public static prodValidate_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(prodValidate_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.xstore.cc.product.pool.service.ProdValidateReqDTO value;
					
					value = new com.vip.xstore.cc.product.pool.service.ProdValidateReqDTO();
					com.vip.xstore.cc.product.pool.service.ProdValidateReqDTOHelper.getInstance().Read(value, iprot);
					
					structs.SetProdValidateReqDTO(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(prodValidate_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetProdValidateReqDTO() != null) {
					
					oprot.WriteFieldBegin("prodValidateReqDTO");
					
					com.vip.xstore.cc.product.pool.service.ProdValidateReqDTOHelper.getInstance().Write(structs.GetProdValidateReqDTO(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("prodValidateReqDTO can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(prodValidate_args bean){
				
				
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
		
		
		
		
		public class prodQuery_resultHelper : TBeanSerializer<prodQuery_result>
		{
			
			public static prodQuery_resultHelper OBJ = new prodQuery_resultHelper();
			
			public static prodQuery_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(prodQuery_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.xstore.cc.product.pool.service.ProdQueryRespDTO value;
					
					value = new com.vip.xstore.cc.product.pool.service.ProdQueryRespDTO();
					com.vip.xstore.cc.product.pool.service.ProdQueryRespDTOHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(prodQuery_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.xstore.cc.product.pool.service.ProdQueryRespDTOHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(prodQuery_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class prodValidate_resultHelper : TBeanSerializer<prodValidate_result>
		{
			
			public static prodValidate_resultHelper OBJ = new prodValidate_resultHelper();
			
			public static prodValidate_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(prodValidate_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.xstore.cc.product.pool.service.ProdValidateRespDTO value;
					
					value = new com.vip.xstore.cc.product.pool.service.ProdValidateRespDTO();
					com.vip.xstore.cc.product.pool.service.ProdValidateRespDTOHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(prodValidate_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.xstore.cc.product.pool.service.ProdValidateRespDTOHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(prodValidate_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class ProductPurchaseServiceClient : OspRestStub , ProductPurchaseService  {
			
			
			public ProductPurchaseServiceClient():base("com.vip.xstore.cc.product.pool.service.ProductPurchaseService","1.0.0") {
				
				
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
			
			
			public com.vip.xstore.cc.product.pool.service.ProdQueryRespDTO prodQuery(com.vip.xstore.cc.product.pool.service.ProdQueryReqDTO prodQueryReqDTO_) {
				
				send_prodQuery(prodQueryReqDTO_);
				return recv_prodQuery(); 
				
			}
			
			
			private void send_prodQuery(com.vip.xstore.cc.product.pool.service.ProdQueryReqDTO prodQueryReqDTO_){
				
				InitInvocation("prodQuery");
				
				prodQuery_args args = new prodQuery_args();
				args.SetProdQueryReqDTO(prodQueryReqDTO_);
				
				SendBase(args, prodQuery_argsHelper.getInstance());
			}
			
			
			private com.vip.xstore.cc.product.pool.service.ProdQueryRespDTO recv_prodQuery(){
				
				prodQuery_result result = new prodQuery_result();
				ReceiveBase(result, prodQuery_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.xstore.cc.product.pool.service.ProdValidateRespDTO prodValidate(com.vip.xstore.cc.product.pool.service.ProdValidateReqDTO prodValidateReqDTO_) {
				
				send_prodValidate(prodValidateReqDTO_);
				return recv_prodValidate(); 
				
			}
			
			
			private void send_prodValidate(com.vip.xstore.cc.product.pool.service.ProdValidateReqDTO prodValidateReqDTO_){
				
				InitInvocation("prodValidate");
				
				prodValidate_args args = new prodValidate_args();
				args.SetProdValidateReqDTO(prodValidateReqDTO_);
				
				SendBase(args, prodValidate_argsHelper.getInstance());
			}
			
			
			private com.vip.xstore.cc.product.pool.service.ProdValidateRespDTO recv_prodValidate(){
				
				prodValidate_result result = new prodValidate_result();
				ReceiveBase(result, prodValidate_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
		}
		
		
	}
	
}