using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.jitx{
	
	
	
	public class FeedbackDeliveryResultRequestHelper : TBeanSerializer<FeedbackDeliveryResultRequest>
	{
		
		public static FeedbackDeliveryResultRequestHelper OBJ = new FeedbackDeliveryResultRequestHelper();
		
		public static FeedbackDeliveryResultRequestHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(FeedbackDeliveryResultRequest structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("vendor_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetVendor_id(value);
					}
					
					
					
					
					
					if ("results".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<vipapis.jitx.FeedbackDeliveryResult> value;
						
						value = new List<vipapis.jitx.FeedbackDeliveryResult>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								vipapis.jitx.FeedbackDeliveryResult elem0;
								
								elem0 = new vipapis.jitx.FeedbackDeliveryResult();
								vipapis.jitx.FeedbackDeliveryResultHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetResults(value);
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
		
		
		public void Write(FeedbackDeliveryResultRequest structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetVendor_id() != null) {
				
				oprot.WriteFieldBegin("vendor_id");
				oprot.WriteI32((int)structs.GetVendor_id()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("vendor_id can not be null!");
			}
			
			
			if(structs.GetResults() != null) {
				
				oprot.WriteFieldBegin("results");
				
				oprot.WriteListBegin();
				foreach(vipapis.jitx.FeedbackDeliveryResult _item0 in structs.GetResults()){
					
					
					vipapis.jitx.FeedbackDeliveryResultHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("results can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(FeedbackDeliveryResultRequest bean){
			
			
		}
		
	}
	
}