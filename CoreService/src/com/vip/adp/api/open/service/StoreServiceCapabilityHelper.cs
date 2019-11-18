using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.adp.api.open.service{
	
	
	
	public class StoreServiceCapabilityHelper : TBeanSerializer<StoreServiceCapability>
	{
		
		public static StoreServiceCapabilityHelper OBJ = new StoreServiceCapabilityHelper();
		
		public static StoreServiceCapabilityHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(StoreServiceCapability structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("storeScore".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetStoreScore(value);
					}
					
					
					
					
					
					if ("storeRankRate".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetStoreRankRate(value);
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
		
		
		public void Write(StoreServiceCapability structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetStoreScore() != null) {
				
				oprot.WriteFieldBegin("storeScore");
				oprot.WriteString(structs.GetStoreScore());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetStoreRankRate() != null) {
				
				oprot.WriteFieldBegin("storeRankRate");
				oprot.WriteString(structs.GetStoreRankRate());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(StoreServiceCapability bean){
			
			
		}
		
	}
	
}