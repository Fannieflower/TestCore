using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.venus.visPo.service{
	
	
	
	public class EBSDataHelper : TBeanSerializer<EBSData>
	{
		
		public static EBSDataHelper OBJ = new EBSDataHelper();
		
		public static EBSDataHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(EBSData structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("reqIebsFlowNum".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetReqIebsFlowNum(value);
					}
					
					
					
					
					
					if ("po".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPo(value);
					}
					
					
					
					
					
					if ("poCount".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPoCount(value);
					}
					
					
					
					
					
					if ("createDate".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCreateDate(value);
					}
					
					
					
					
					
					if ("batchNum".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetBatchNum(value);
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
		
		
		public void Write(EBSData structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetReqIebsFlowNum() != null) {
				
				oprot.WriteFieldBegin("reqIebsFlowNum");
				oprot.WriteString(structs.GetReqIebsFlowNum());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPo() != null) {
				
				oprot.WriteFieldBegin("po");
				oprot.WriteString(structs.GetPo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPoCount() != null) {
				
				oprot.WriteFieldBegin("poCount");
				oprot.WriteString(structs.GetPoCount());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCreateDate() != null) {
				
				oprot.WriteFieldBegin("createDate");
				oprot.WriteString(structs.GetCreateDate());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBatchNum() != null) {
				
				oprot.WriteFieldBegin("batchNum");
				oprot.WriteI32((int)structs.GetBatchNum()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("batchNum can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(EBSData bean){
			
			
		}
		
	}
	
}