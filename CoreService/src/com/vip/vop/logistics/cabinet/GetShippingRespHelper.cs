using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.logistics.cabinet{
	
	
	
	public class GetShippingRespHelper : TBeanSerializer<GetShippingResp>
	{
		
		public static GetShippingRespHelper OBJ = new GetShippingRespHelper();
		
		public static GetShippingRespHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(GetShippingResp structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("shippings".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.vop.logistics.cabinet.Shipping> value;
						
						value = new List<com.vip.vop.logistics.cabinet.Shipping>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.vop.logistics.cabinet.Shipping elem1;
								
								elem1 = new com.vip.vop.logistics.cabinet.Shipping();
								com.vip.vop.logistics.cabinet.ShippingHelper.getInstance().Read(elem1, iprot);
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetShippings(value);
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
		
		
		public void Write(GetShippingResp structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetShippings() != null) {
				
				oprot.WriteFieldBegin("shippings");
				
				oprot.WriteListBegin();
				foreach(com.vip.vop.logistics.cabinet.Shipping _item0 in structs.GetShippings()){
					
					
					com.vip.vop.logistics.cabinet.ShippingHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(GetShippingResp bean){
			
			
		}
		
	}
	
}