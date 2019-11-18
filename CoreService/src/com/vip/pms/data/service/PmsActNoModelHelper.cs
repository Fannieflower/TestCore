using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.pms.data.service{
	
	
	
	public class PmsActNoModelHelper : TBeanSerializer<PmsActNoModel>
	{
		
		public static PmsActNoModelHelper OBJ = new PmsActNoModelHelper();
		
		public static PmsActNoModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(PmsActNoModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("actPlatform".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetActPlatform(value);
					}
					
					
					
					
					
					if ("actnoToApi".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetActnoToApi(value);
					}
					
					
					
					
					
					if ("actPlatformList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<int?> value;
						
						value = new List<int?>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								int elem0;
								elem0 = iprot.ReadI32(); 
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetActPlatformList(value);
					}
					
					
					
					
					
					if ("promotionObjectId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetPromotionObjectId(value);
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
		
		
		public void Write(PmsActNoModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetActPlatform() != null) {
				
				oprot.WriteFieldBegin("actPlatform");
				oprot.WriteI32((int)structs.GetActPlatform()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetActnoToApi() != null) {
				
				oprot.WriteFieldBegin("actnoToApi");
				oprot.WriteString(structs.GetActnoToApi());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("actnoToApi can not be null!");
			}
			
			
			if(structs.GetActPlatformList() != null) {
				
				oprot.WriteFieldBegin("actPlatformList");
				
				oprot.WriteListBegin();
				foreach(int _item0 in structs.GetActPlatformList()){
					
					oprot.WriteI32((int)_item0); 
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPromotionObjectId() != null) {
				
				oprot.WriteFieldBegin("promotionObjectId");
				oprot.WriteI64((long)structs.GetPromotionObjectId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(PmsActNoModel bean){
			
			
		}
		
	}
	
}