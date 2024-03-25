using BlazorServerProj.Models;

namespace BlazorServerProj.Interfaces
{
    public interface IDatabase<T>
    {
        // 테이블 전체 데이터 조회
        Task<List<T>> GetAsync();
        // 테이블 특정 ID 조회
        T GetDetail(int? id);
        // 새로운 행을 생성
        void Create(T entity);
        // 기존 행을 수정
        void Update(int? id,T entity);
        // 기존 행을 삭제
        void Delete(int? id);
    }
}
