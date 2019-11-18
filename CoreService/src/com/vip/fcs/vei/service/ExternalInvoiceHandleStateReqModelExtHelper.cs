using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.fcs.vei.service{
	
	
	
	public class ExternalInvoiceHandleStateReqModelExtHelper : TBeanSerializer<ExternalInvoiceHandleStateReqModelExt>
	{
		
		public static ExternalInvoiceHandleStateReqModelExtHelper OBJ = new ExternalInvoiceHandleStateReqModelExtHelper();
		
		public static ExternalInvoiceHandleStateReqModelExtHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ExternalInvoiceHandleStateReqModelExt structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("queryModelList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.fcs.vei.service.ExternalInvoiceHandleStateQueryModel> value;
						
						value = new List<com.vip.fcs.vei.service.ExternalInvoiceHandleStateQueryModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.fcs.vei.service.ExternalInvoiceHandleStateQueryModel elem0;
								
								elem0 = new com.vip.fcs.vei.service.ExternalInvoiceHandleStateQueryModel();
								com.vip.fcs.vei.service.ExternalInvoiceHandleStateQueryModelHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetQueryModelList(value);
					}
					
					
					
					
					
					if ("limit".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetLimit(value);
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
		
		
		public void Write(ExternalInvoiceHandleStateReqModelExt structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetQueryModelList() != null) {
				
				oprot.WriteFieldBegin("queryModelList");
				
				oprot.WriteListBegin();
				foreach(com.vip.fcs.vei.service.ExternalInvoiceHandleStateQueryModel _item0 in structs.GetQueryModelList()){
					
					
					com.vip.fcs.vei.service.ExternalInvoiceHandleStateQueryModelHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("queryModelList can not be null!");
			}
			
			
			if(structs.GetLimit() != null) {
				
				oprot.WriteFieldBegin("limit");
				oprot.WriteI32((int)structs.GetLimit()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ExternalInvoiceHandleStateReqModelExt bean){
			
			
		}
		
	}
	
}