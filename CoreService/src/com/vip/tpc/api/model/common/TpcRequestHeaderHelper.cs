using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.tpc.api.model.common{
	
	
	
	public class TpcRequestHeaderHelper : TBeanSerializer<TpcRequestHeader>
	{
		
		public static TpcRequestHeaderHelper OBJ = new TpcRequestHeaderHelper();
		
		public static TpcRequestHeaderHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(TpcRequestHeader structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("calledDomain".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCalledDomain(value);
					}
					
					
					
					
					
					if ("requestTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetRequestTime(value);
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
		
		
		public void Write(TpcRequestHeader structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetCalledDomain() != null) {
				
				oprot.WriteFieldBegin("calledDomain");
				oprot.WriteString(structs.GetCalledDomain());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRequestTime() != null) {
				
				oprot.WriteFieldBegin("requestTime");
				oprot.WriteI64((long)structs.GetRequestTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("requestTime can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(TpcRequestHeader bean){
			
			
		}
		
	}
	
}