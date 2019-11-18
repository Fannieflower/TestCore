using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.xstore.cc.bulkbuying.model{
	
	
	
	public class PaginationModelHelper : TBeanSerializer<PaginationModel>
	{
		
		public static PaginationModelHelper OBJ = new PaginationModelHelper();
		
		public static PaginationModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(PaginationModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("totalCounts".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetTotalCounts(value);
					}
					
					
					
					
					
					if ("totalPages".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetTotalPages(value);
					}
					
					
					
					
					
					if ("hasPrevs".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool value;
						value = iprot.ReadBool();
						
						structs.SetHasPrevs(value);
					}
					
					
					
					
					
					if ("hasNext".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool value;
						value = iprot.ReadBool();
						
						structs.SetHasNext(value);
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
		
		
		public void Write(PaginationModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetTotalCounts() != null) {
				
				oprot.WriteFieldBegin("totalCounts");
				oprot.WriteI64((long)structs.GetTotalCounts()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTotalPages() != null) {
				
				oprot.WriteFieldBegin("totalPages");
				oprot.WriteI32((int)structs.GetTotalPages()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetHasPrevs() != null) {
				
				oprot.WriteFieldBegin("hasPrevs");
				oprot.WriteBool((bool)structs.GetHasPrevs());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("hasPrevs can not be null!");
			}
			
			
			if(structs.GetHasNext() != null) {
				
				oprot.WriteFieldBegin("hasNext");
				oprot.WriteBool((bool)structs.GetHasNext());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("hasNext can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(PaginationModel bean){
			
			
		}
		
	}
	
}