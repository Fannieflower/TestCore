using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.marketplace.delivery{
	
	
	
	public class BatchGetCancelInfoResponseHelper : TBeanSerializer<BatchGetCancelInfoResponse>
	{
		
		public static BatchGetCancelInfoResponseHelper OBJ = new BatchGetCancelInfoResponseHelper();
		
		public static BatchGetCancelInfoResponseHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(BatchGetCancelInfoResponse structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("total".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetTotal(value);
					}
					
					
					
					
					
					if ("cancelInfos".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<vipapis.marketplace.delivery.GetCancelInfoResponse> value;
						
						value = new List<vipapis.marketplace.delivery.GetCancelInfoResponse>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								vipapis.marketplace.delivery.GetCancelInfoResponse elem0;
								
								elem0 = new vipapis.marketplace.delivery.GetCancelInfoResponse();
								vipapis.marketplace.delivery.GetCancelInfoResponseHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetCancelInfos(value);
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
		
		
		public void Write(BatchGetCancelInfoResponse structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetTotal() != null) {
				
				oprot.WriteFieldBegin("total");
				oprot.WriteI32((int)structs.GetTotal()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("total can not be null!");
			}
			
			
			if(structs.GetCancelInfos() != null) {
				
				oprot.WriteFieldBegin("cancelInfos");
				
				oprot.WriteListBegin();
				foreach(vipapis.marketplace.delivery.GetCancelInfoResponse _item0 in structs.GetCancelInfos()){
					
					
					vipapis.marketplace.delivery.GetCancelInfoResponseHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(BatchGetCancelInfoResponse bean){
			
			
		}
		
	}
	
}