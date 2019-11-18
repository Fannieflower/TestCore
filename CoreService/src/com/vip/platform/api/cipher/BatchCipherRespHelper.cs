using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.platform.api.cipher{
	
	
	
	public class BatchCipherRespHelper : TBeanSerializer<BatchCipherResp>
	{
		
		public static BatchCipherRespHelper OBJ = new BatchCipherRespHelper();
		
		public static BatchCipherRespHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(BatchCipherResp structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("resultMap".Equals(schemeField.Trim())){
						
						needSkip = false;
						Dictionary<string, com.vip.platform.api.cipher.CipherResult> value;
						
						value = new Dictionary<string, com.vip.platform.api.cipher.CipherResult>();
						iprot.ReadMapBegin();
						while(true){
							
							try{
								
								string _key0;
								com.vip.platform.api.cipher.CipherResult _val0;
								_key0 = iprot.ReadString();
								
								
								_val0 = new com.vip.platform.api.cipher.CipherResult();
								com.vip.platform.api.cipher.CipherResultHelper.getInstance().Read(_val0, iprot);
								
								value.Add(_key0, _val0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadMapEnd();
						
						structs.SetResultMap(value);
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
		
		
		public void Write(BatchCipherResp structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetResultMap() != null) {
				
				oprot.WriteFieldBegin("resultMap");
				
				oprot.WriteMapBegin();
				foreach(KeyValuePair< string, com.vip.platform.api.cipher.CipherResult > _ir0 in structs.GetResultMap()){
					
					string _key0 = _ir0.Key;
					com.vip.platform.api.cipher.CipherResult _value0 = _ir0.Value;
					oprot.WriteString(_key0);
					
					
					com.vip.platform.api.cipher.CipherResultHelper.getInstance().Write(_value0, oprot);
					
				}
				
				oprot.WriteMapEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(BatchCipherResp bean){
			
			
		}
		
	}
	
}