using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.top.carrier.bizservice{
	
	
	
	public class SortingInfoRequestHeadHelper : TBeanSerializer<SortingInfoRequestHead>
	{
		
		public static SortingInfoRequestHeadHelper OBJ = new SortingInfoRequestHeadHelper();
		
		public static SortingInfoRequestHeadHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(SortingInfoRequestHead structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("batchno".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBatchno(value);
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
		
		
		public void Write(SortingInfoRequestHead structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetBatchno() != null) {
				
				oprot.WriteFieldBegin("batchno");
				oprot.WriteString(structs.GetBatchno());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(SortingInfoRequestHead bean){
			
			
		}
		
	}
	
}