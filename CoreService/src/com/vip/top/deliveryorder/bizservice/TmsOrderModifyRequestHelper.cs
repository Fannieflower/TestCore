using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.top.deliveryorder.bizservice{
	
	
	
	public class TmsOrderModifyRequestHelper : TBeanSerializer<TmsOrderModifyRequest>
	{
		
		public static TmsOrderModifyRequestHelper OBJ = new TmsOrderModifyRequestHelper();
		
		public static TmsOrderModifyRequestHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(TmsOrderModifyRequest structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("orderSn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrderSn(value);
					}
					
					
					
					
					
					if ("isJitX".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetIsJitX(value);
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
		
		
		public void Write(TmsOrderModifyRequest structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetOrderSn() != null) {
				
				oprot.WriteFieldBegin("orderSn");
				oprot.WriteString(structs.GetOrderSn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsJitX() != null) {
				
				oprot.WriteFieldBegin("isJitX");
				oprot.WriteI32((int)structs.GetIsJitX()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("isJitX can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(TmsOrderModifyRequest bean){
			
			
		}
		
	}
	
}