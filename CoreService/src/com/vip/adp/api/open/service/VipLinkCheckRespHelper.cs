using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.adp.api.open.service{
	
	
	
	public class VipLinkCheckRespHelper : TBeanSerializer<VipLinkCheckResp>
	{
		
		public static VipLinkCheckRespHelper OBJ = new VipLinkCheckRespHelper();
		
		public static VipLinkCheckRespHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(VipLinkCheckResp structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("successMap".Equals(schemeField.Trim())){
						
						needSkip = false;
						Dictionary<string, com.vip.adp.api.open.service.VipLinkCheckVO> value;
						
						value = new Dictionary<string, com.vip.adp.api.open.service.VipLinkCheckVO>();
						iprot.ReadMapBegin();
						while(true){
							
							try{
								
								string _key0;
								com.vip.adp.api.open.service.VipLinkCheckVO _val0;
								_key0 = iprot.ReadString();
								
								
								_val0 = new com.vip.adp.api.open.service.VipLinkCheckVO();
								com.vip.adp.api.open.service.VipLinkCheckVOHelper.getInstance().Read(_val0, iprot);
								
								value.Add(_key0, _val0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadMapEnd();
						
						structs.SetSuccessMap(value);
					}
					
					
					
					
					
					if ("failMap".Equals(schemeField.Trim())){
						
						needSkip = false;
						Dictionary<string, com.vip.adp.api.open.service.VipLinkCheckVO> value;
						
						value = new Dictionary<string, com.vip.adp.api.open.service.VipLinkCheckVO>();
						iprot.ReadMapBegin();
						while(true){
							
							try{
								
								string _key2;
								com.vip.adp.api.open.service.VipLinkCheckVO _val2;
								_key2 = iprot.ReadString();
								
								
								_val2 = new com.vip.adp.api.open.service.VipLinkCheckVO();
								com.vip.adp.api.open.service.VipLinkCheckVOHelper.getInstance().Read(_val2, iprot);
								
								value.Add(_key2, _val2);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadMapEnd();
						
						structs.SetFailMap(value);
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
		
		
		public void Write(VipLinkCheckResp structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetSuccessMap() != null) {
				
				oprot.WriteFieldBegin("successMap");
				
				oprot.WriteMapBegin();
				foreach(KeyValuePair< string, com.vip.adp.api.open.service.VipLinkCheckVO > _ir0 in structs.GetSuccessMap()){
					
					string _key0 = _ir0.Key;
					com.vip.adp.api.open.service.VipLinkCheckVO _value0 = _ir0.Value;
					oprot.WriteString(_key0);
					
					
					com.vip.adp.api.open.service.VipLinkCheckVOHelper.getInstance().Write(_value0, oprot);
					
				}
				
				oprot.WriteMapEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetFailMap() != null) {
				
				oprot.WriteFieldBegin("failMap");
				
				oprot.WriteMapBegin();
				foreach(KeyValuePair< string, com.vip.adp.api.open.service.VipLinkCheckVO > _ir0 in structs.GetFailMap()){
					
					string _key0 = _ir0.Key;
					com.vip.adp.api.open.service.VipLinkCheckVO _value0 = _ir0.Value;
					oprot.WriteString(_key0);
					
					
					com.vip.adp.api.open.service.VipLinkCheckVOHelper.getInstance().Write(_value0, oprot);
					
				}
				
				oprot.WriteMapEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(VipLinkCheckResp bean){
			
			
		}
		
	}
	
}