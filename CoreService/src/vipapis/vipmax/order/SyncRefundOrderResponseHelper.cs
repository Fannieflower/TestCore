using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.vipmax.order{
	
	
	
	public class SyncRefundOrderResponseHelper : TBeanSerializer<SyncRefundOrderResponse>
	{
		
		public static SyncRefundOrderResponseHelper OBJ = new SyncRefundOrderResponseHelper();
		
		public static SyncRefundOrderResponseHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(SyncRefundOrderResponse structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("refund_order_sn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRefund_order_sn(value);
					}
					
					
					
					
					
					if ("origin_out_order_sn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrigin_out_order_sn(value);
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
		
		
		public void Write(SyncRefundOrderResponse structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetRefund_order_sn() != null) {
				
				oprot.WriteFieldBegin("refund_order_sn");
				oprot.WriteString(structs.GetRefund_order_sn());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("refund_order_sn can not be null!");
			}
			
			
			if(structs.GetOrigin_out_order_sn() != null) {
				
				oprot.WriteFieldBegin("origin_out_order_sn");
				oprot.WriteString(structs.GetOrigin_out_order_sn());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("origin_out_order_sn can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(SyncRefundOrderResponse bean){
			
			
		}
		
	}
	
}