using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.platform.api.cipher{
	
	
	
	public class BatchEncryptReqHelper : TBeanSerializer<BatchEncryptReq>
	{
		
		public static BatchEncryptReqHelper OBJ = new BatchEncryptReqHelper();
		
		public static BatchEncryptReqHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(BatchEncryptReq structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("keyCategory".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetKeyCategory(value);
					}
					
					
					
					
					
					if ("contents".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<string> value;
						
						value = new List<string>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								string elem1;
								elem1 = iprot.ReadString();
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetContents(value);
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
		
		
		public void Write(BatchEncryptReq structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetKeyCategory() != null) {
				
				oprot.WriteFieldBegin("keyCategory");
				oprot.WriteString(structs.GetKeyCategory());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("keyCategory can not be null!");
			}
			
			
			if(structs.GetContents() != null) {
				
				oprot.WriteFieldBegin("contents");
				
				oprot.WriteListBegin();
				foreach(string _item0 in structs.GetContents()){
					
					oprot.WriteString(_item0);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("contents can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(BatchEncryptReq bean){
			
			
		}
		
	}
	
}