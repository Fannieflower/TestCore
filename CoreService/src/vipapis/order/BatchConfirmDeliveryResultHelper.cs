using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.order{
	
	
	
	public class BatchConfirmDeliveryResultHelper : TBeanSerializer<BatchConfirmDeliveryResult>
	{
		
		public static BatchConfirmDeliveryResultHelper OBJ = new BatchConfirmDeliveryResultHelper();
		
		public static BatchConfirmDeliveryResultHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(BatchConfirmDeliveryResult structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("data".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<vipapis.order.ConfirmDeliveryFailItem> value;
						
						value = new List<vipapis.order.ConfirmDeliveryFailItem>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								vipapis.order.ConfirmDeliveryFailItem elem0;
								
								elem0 = new vipapis.order.ConfirmDeliveryFailItem();
								vipapis.order.ConfirmDeliveryFailItemHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
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
		
		
		public void Write(BatchConfirmDeliveryResult structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetData() != null) {
				
				oprot.WriteFieldBegin("data");
				
				oprot.WriteListBegin();
				foreach(vipapis.order.ConfirmDeliveryFailItem _item0 in structs.GetData()){
					
					
					vipapis.order.ConfirmDeliveryFailItemHelper.getInstance().Write(_item0, oprot);
					
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
		
		
		public void Validate(BatchConfirmDeliveryResult bean){
			
			
		}
		
	}
	
}