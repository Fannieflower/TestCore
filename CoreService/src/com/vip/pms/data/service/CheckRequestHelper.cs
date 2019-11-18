using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.pms.data.service{
	
	
	
	public class CheckRequestHelper : TBeanSerializer<CheckRequest>
	{
		
		public static CheckRequestHelper OBJ = new CheckRequestHelper();
		
		public static CheckRequestHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(CheckRequest structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("opcode".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetOpcode(value);
					}
					
					
					
					
					
					if ("cacheType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetCacheType(value);
					}
					
					
					
					
					
					if ("keys".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<string> value;
						
						value = new List<string>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								string elem0;
								elem0 = iprot.ReadString();
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetKeys(value);
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
		
		
		public void Write(CheckRequest structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetOpcode() != null) {
				
				oprot.WriteFieldBegin("opcode");
				oprot.WriteI32((int)structs.GetOpcode()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("opcode can not be null!");
			}
			
			
			if(structs.GetCacheType() != null) {
				
				oprot.WriteFieldBegin("cacheType");
				oprot.WriteI32((int)structs.GetCacheType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetKeys() != null) {
				
				oprot.WriteFieldBegin("keys");
				
				oprot.WriteListBegin();
				foreach(string _item0 in structs.GetKeys()){
					
					oprot.WriteString(_item0);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(CheckRequest bean){
			
			
		}
		
	}
	
}