using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.logistics.carrier.service{
	
	
	
	public class ShippingInterceptRespHelper : TBeanSerializer<ShippingInterceptResp>
	{
		
		public static ShippingInterceptRespHelper OBJ = new ShippingInterceptRespHelper();
		
		public static ShippingInterceptRespHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ShippingInterceptResp structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("carrier_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCarrier_code(value);
					}
					
					
					
					
					
					if ("intercept_results".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.vop.logistics.carrier.service.InterceptResult> value;
						
						value = new List<com.vip.vop.logistics.carrier.service.InterceptResult>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.vop.logistics.carrier.service.InterceptResult elem0;
								
								elem0 = new com.vip.vop.logistics.carrier.service.InterceptResult();
								com.vip.vop.logistics.carrier.service.InterceptResultHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetIntercept_results(value);
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
		
		
		public void Write(ShippingInterceptResp structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetCarrier_code() != null) {
				
				oprot.WriteFieldBegin("carrier_code");
				oprot.WriteString(structs.GetCarrier_code());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIntercept_results() != null) {
				
				oprot.WriteFieldBegin("intercept_results");
				
				oprot.WriteListBegin();
				foreach(com.vip.vop.logistics.carrier.service.InterceptResult _item0 in structs.GetIntercept_results()){
					
					
					com.vip.vop.logistics.carrier.service.InterceptResultHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ShippingInterceptResp bean){
			
			
		}
		
	}
	
}