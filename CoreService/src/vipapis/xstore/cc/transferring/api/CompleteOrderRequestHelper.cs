using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.xstore.cc.transferring.api{
	
	
	
	public class CompleteOrderRequestHelper : TBeanSerializer<CompleteOrderRequest>
	{
		
		public static CompleteOrderRequestHelper OBJ = new CompleteOrderRequestHelper();
		
		public static CompleteOrderRequestHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(CompleteOrderRequest structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("transferring_order_no".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTransferring_order_no(value);
					}
					
					
					
					
					
					if ("total_qty".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetTotal_qty(value);
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
		
		
		public void Write(CompleteOrderRequest structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetTransferring_order_no() != null) {
				
				oprot.WriteFieldBegin("transferring_order_no");
				oprot.WriteString(structs.GetTransferring_order_no());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("transferring_order_no can not be null!");
			}
			
			
			if(structs.GetTotal_qty() != null) {
				
				oprot.WriteFieldBegin("total_qty");
				oprot.WriteI32((int)structs.GetTotal_qty()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("total_qty can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(CompleteOrderRequest bean){
			
			
		}
		
	}
	
}