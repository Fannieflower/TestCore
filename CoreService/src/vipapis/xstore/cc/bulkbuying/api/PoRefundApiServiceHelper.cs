using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace vipapis.xstore.cc.bulkbuying.api{
	
	
	public class PoRefundApiServiceHelper {
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class updatePoRefundRealQty_args {
			
			///<summary>
			/// 更新退供单实际出仓数量请求
			///</summary>
			
			private vipapis.xstore.cc.bulkbuying.api.UpdatePoRefundRealQtyReq req_;
			
			public vipapis.xstore.cc.bulkbuying.api.UpdatePoRefundRealQtyReq GetReq(){
				return this.req_;
			}
			
			public void SetReq(vipapis.xstore.cc.bulkbuying.api.UpdatePoRefundRealQtyReq value){
				this.req_ = value;
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
		
		
		
		
		public class updatePoRefundRealQty_result {
			
			///<summary>
			///</summary>
			
			private Dictionary<string, vipapis.xstore.cc.bulkbuying.api.UpdatePoRefundRealQtyResult> success_;
			
			public Dictionary<string, vipapis.xstore.cc.bulkbuying.api.UpdatePoRefundRealQtyResult> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(Dictionary<string, vipapis.xstore.cc.bulkbuying.api.UpdatePoRefundRealQtyResult> value){
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
		
		
		
		
		public class updatePoRefundRealQty_argsHelper : TBeanSerializer<updatePoRefundRealQty_args>
		{
			
			public static updatePoRefundRealQty_argsHelper OBJ = new updatePoRefundRealQty_argsHelper();
			
			public static updatePoRefundRealQty_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updatePoRefundRealQty_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.xstore.cc.bulkbuying.api.UpdatePoRefundRealQtyReq value;
					
					value = new vipapis.xstore.cc.bulkbuying.api.UpdatePoRefundRealQtyReq();
					vipapis.xstore.cc.bulkbuying.api.UpdatePoRefundRealQtyReqHelper.getInstance().Read(value, iprot);
					
					structs.SetReq(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updatePoRefundRealQty_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetReq() != null) {
					
					oprot.WriteFieldBegin("req");
					
					vipapis.xstore.cc.bulkbuying.api.UpdatePoRefundRealQtyReqHelper.getInstance().Write(structs.GetReq(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("req can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(updatePoRefundRealQty_args bean){
				
				
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
		
		
		
		
		public class updatePoRefundRealQty_resultHelper : TBeanSerializer<updatePoRefundRealQty_result>
		{
			
			public static updatePoRefundRealQty_resultHelper OBJ = new updatePoRefundRealQty_resultHelper();
			
			public static updatePoRefundRealQty_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updatePoRefundRealQty_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					Dictionary<string, vipapis.xstore.cc.bulkbuying.api.UpdatePoRefundRealQtyResult> value;
					
					value = new Dictionary<string, vipapis.xstore.cc.bulkbuying.api.UpdatePoRefundRealQtyResult>();
					iprot.ReadMapBegin();
					while(true){
						
						try{
							
							string _key0;
							vipapis.xstore.cc.bulkbuying.api.UpdatePoRefundRealQtyResult _val0;
							_key0 = iprot.ReadString();
							
							
							_val0 = new vipapis.xstore.cc.bulkbuying.api.UpdatePoRefundRealQtyResult();
							vipapis.xstore.cc.bulkbuying.api.UpdatePoRefundRealQtyResultHelper.getInstance().Read(_val0, iprot);
							
							value.Add(_key0, _val0);
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
			
			
			public void Write(updatePoRefundRealQty_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteMapBegin();
					foreach(KeyValuePair< string, vipapis.xstore.cc.bulkbuying.api.UpdatePoRefundRealQtyResult > _ir0 in structs.GetSuccess()){
						
						string _key0 = _ir0.Key;
						vipapis.xstore.cc.bulkbuying.api.UpdatePoRefundRealQtyResult _value0 = _ir0.Value;
						oprot.WriteString(_key0);
						
						
						vipapis.xstore.cc.bulkbuying.api.UpdatePoRefundRealQtyResultHelper.getInstance().Write(_value0, oprot);
						
					}
					
					oprot.WriteMapEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(updatePoRefundRealQty_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class PoRefundApiServiceClient : OspRestStub , PoRefundApiService  {
			
			
			public PoRefundApiServiceClient():base("vipapis.xstore.cc.bulkbuying.api.PoRefundApiService","1.0.0") {
				
				
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
			
			
			public Dictionary<string, vipapis.xstore.cc.bulkbuying.api.UpdatePoRefundRealQtyResult> updatePoRefundRealQty(vipapis.xstore.cc.bulkbuying.api.UpdatePoRefundRealQtyReq req_) {
				
				send_updatePoRefundRealQty(req_);
				return recv_updatePoRefundRealQty(); 
				
			}
			
			
			private void send_updatePoRefundRealQty(vipapis.xstore.cc.bulkbuying.api.UpdatePoRefundRealQtyReq req_){
				
				InitInvocation("updatePoRefundRealQty");
				
				updatePoRefundRealQty_args args = new updatePoRefundRealQty_args();
				args.SetReq(req_);
				
				SendBase(args, updatePoRefundRealQty_argsHelper.getInstance());
			}
			
			
			private Dictionary<string, vipapis.xstore.cc.bulkbuying.api.UpdatePoRefundRealQtyResult> recv_updatePoRefundRealQty(){
				
				updatePoRefundRealQty_result result = new updatePoRefundRealQty_result();
				ReceiveBase(result, updatePoRefundRealQty_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
		}
		
		
	}
	
}