using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.order{
	
	
	
	public class BatchConfirmDeliveryRequestHelper : TBeanSerializer<BatchConfirmDeliveryRequest>
	{
		
		public static BatchConfirmDeliveryRequestHelper OBJ = new BatchConfirmDeliveryRequestHelper();
		
		public static BatchConfirmDeliveryRequestHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(BatchConfirmDeliveryRequest structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("data".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<vipapis.order.ConfirmDelivery> value;
						
						value = new List<vipapis.order.ConfirmDelivery>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								vipapis.order.ConfirmDelivery elem1;
								
								elem1 = new vipapis.order.ConfirmDelivery();
								vipapis.order.ConfirmDeliveryHelper.getInstance().Read(elem1, iprot);
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetData(value);
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
		
		
		public void Write(BatchConfirmDeliveryRequest structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetData() != null) {
				
				oprot.WriteFieldBegin("data");
				
				oprot.WriteListBegin();
				foreach(vipapis.order.ConfirmDelivery _item0 in structs.GetData()){
					
					
					vipapis.order.ConfirmDeliveryHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("data can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(BatchConfirmDeliveryRequest bean){
			
			
		}
		
	}
	
}