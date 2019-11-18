using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.order{
	
	
	
	public class ConfirmDeliveryFailItemHelper : TBeanSerializer<ConfirmDeliveryFailItem>
	{
		
		public static ConfirmDeliveryFailItemHelper OBJ = new ConfirmDeliveryFailItemHelper();
		
		public static ConfirmDeliveryFailItemHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ConfirmDeliveryFailItem structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("code".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetCode(value);
					}
					
					
					
					
					
					if ("message".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetMessage(value);
					}
					
					
					
					
					
					if ("item".Equals(schemeField.Trim())){
						
						needSkip = false;
						vipapis.order.ConfirmDelivery value;
						
						value = new vipapis.order.ConfirmDelivery();
						vipapis.order.ConfirmDeliveryHelper.getInstance().Read(value, iprot);
						
						structs.SetItem(value);
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
		
		
		public void Write(ConfirmDeliveryFailItem structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetCode() != null) {
				
				oprot.WriteFieldBegin("code");
				oprot.WriteI32((int)structs.GetCode()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMessage() != null) {
				
				oprot.WriteFieldBegin("message");
				oprot.WriteString(structs.GetMessage());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("message can not be null!");
			}
			
			
			if(structs.GetItem() != null) {
				
				oprot.WriteFieldBegin("item");
				
				vipapis.order.ConfirmDeliveryHelper.getInstance().Write(structs.GetItem(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("item can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ConfirmDeliveryFailItem bean){
			
			
		}
		
	}
	
}