using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.cup.api.aftersale{
	
	
	
	public class UpdateReturnRefundResultReqHelper : TBeanSerializer<UpdateReturnRefundResultReq>
	{
		
		public static UpdateReturnRefundResultReqHelper OBJ = new UpdateReturnRefundResultReqHelper();
		
		public static UpdateReturnRefundResultReqHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(UpdateReturnRefundResultReq structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("apply_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetApply_id(value);
					}
					
					
					
					
					
					if ("order_sn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrder_sn(value);
					}
					
					
					
					
					
					if ("user_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetUser_code(value);
					}
					
					
					
					
					
					if ("refund_money".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRefund_money(value);
					}
					
					
					
					
					
					if ("seller_refund_money".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSeller_refund_money(value);
					}
					
					
					
					
					
					if ("refund_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRefund_time(value);
					}
					
					
					
					
					if(needSkip){
						
						ProtocolUtil.skip(iprot);
					}
					
					iprot.ReadFieldEnd();
				}
				
				iprot.ReadStructEnd();
				Validate(structs);
			}
			else{
				
				throw new OspException();
			}
			
			
		}
		
		
		public void Write(UpdateReturnRefundResultReq structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetApply_id() != null) {
				
				oprot.WriteFieldBegin("apply_id");
				oprot.WriteString(structs.GetApply_id());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("apply_id can not be null!");
			}
			
			
			if(structs.GetOrder_sn() != null) {
				
				oprot.WriteFieldBegin("order_sn");
				oprot.WriteString(structs.GetOrder_sn());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("order_sn can not be null!");
			}
			
			
			if(structs.GetUser_code() != null) {
				
				oprot.WriteFieldBegin("user_code");
				oprot.WriteString(structs.GetUser_code());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("user_code can not be null!");
			}
			
			
			if(structs.GetRefund_money() != null) {
				
				oprot.WriteFieldBegin("refund_money");
				oprot.WriteString(structs.GetRefund_money());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("refund_money can not be null!");
			}
			
			
			if(structs.GetSeller_refund_money() != null) {
				
				oprot.WriteFieldBegin("seller_refund_money");
				oprot.WriteString(structs.GetSeller_refund_money());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("seller_refund_money can not be null!");
			}
			
			
			if(structs.GetRefund_time() != null) {
				
				oprot.WriteFieldBegin("refund_time");
				oprot.WriteString(structs.GetRefund_time());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("refund_time can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(UpdateReturnRefundResultReq bean){
			
			
		}
		
	}
	
}