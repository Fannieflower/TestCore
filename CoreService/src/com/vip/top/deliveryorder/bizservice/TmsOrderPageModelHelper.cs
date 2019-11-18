using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.top.deliveryorder.bizservice{
	
	
	
	public class TmsOrderPageModelHelper : TBeanSerializer<TmsOrderPageModel>
	{
		
		public static TmsOrderPageModelHelper OBJ = new TmsOrderPageModelHelper();
		
		public static TmsOrderPageModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(TmsOrderPageModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("tmsOrderUnionModels".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.top.deliveryorder.service.TmsOrderUnionModel> value;
						
						value = new List<com.vip.top.deliveryorder.service.TmsOrderUnionModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.top.deliveryorder.service.TmsOrderUnionModel elem0;
								
								elem0 = new com.vip.top.deliveryorder.service.TmsOrderUnionModel();
								com.vip.top.deliveryorder.service.TmsOrderUnionModelHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetTmsOrderUnionModels(value);
					}
					
					
					
					
					
					if ("totalRecord".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetTotalRecord(value);
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
		
		
		public void Write(TmsOrderPageModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetTmsOrderUnionModels() != null) {
				
				oprot.WriteFieldBegin("tmsOrderUnionModels");
				
				oprot.WriteListBegin();
				foreach(com.vip.top.deliveryorder.service.TmsOrderUnionModel _item0 in structs.GetTmsOrderUnionModels()){
					
					
					com.vip.top.deliveryorder.service.TmsOrderUnionModelHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTotalRecord() != null) {
				
				oprot.WriteFieldBegin("totalRecord");
				oprot.WriteI32((int)structs.GetTotalRecord()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(TmsOrderPageModel bean){
			
			
		}
		
	}
	
}